$vdprojPath = "$PSScriptRoot\RawVideoCutterSetup\RawVideoCutterSetup.vdproj"
$pluginsDir = "$env:USERPROFILE\Desktop\vlc-plugins"
$folderKey  = "_8DF3274382364C74830E9C6A8EDA05D4"
$fileGuid   = "{1FB2D0AE-D3B9-43D4-B9DD-F88EC61E35DE}"

$content  = [System.IO.File]::ReadAllText($vdprojPath)
$nl       = if ($content.Contains("`r`n")) { "`r`n" } else { "`n" }

$existing = [regex]::Matches($content, '"TargetName" = "8:(lib[^"]+_plugin\.dll)"') |
    ForEach-Object { $_.Groups[1].Value }

$all = Get-ChildItem $pluginsDir -Filter "*_plugin.dll" | Sort-Object Name

$lines = [System.Collections.Generic.List[string]]::new()
foreach ($f in $all) {
    if ($existing -contains $f.Name) { continue }
    $key     = "_" + [guid]::NewGuid().ToString("N").ToUpper()
    $relPath = "..\\..\\..\\..\\Desktop\\vlc-plugins\\" + $f.Name
    $lines.Add("            `"$fileGuid`:$key`"")
    $lines.Add("            {")
    $lines.Add("            `"SourcePath`" = `"8:$relPath`"")
    $lines.Add("            `"TargetName`" = `"8:$($f.Name)`"")
    $lines.Add("            `"Tag`" = `"8:`"")
    $lines.Add("            `"Folder`" = `"8:$folderKey`"")
    $lines.Add("            `"Condition`" = `"8:`"")
    $lines.Add("            `"Transitive`" = `"11:FALSE`"")
    $lines.Add("            `"Vital`" = `"11:TRUE`"")
    $lines.Add("            `"ReadOnly`" = `"11:FALSE`"")
    $lines.Add("            `"Hidden`" = `"11:FALSE`"")
    $lines.Add("            `"System`" = `"11:FALSE`"")
    $lines.Add("            `"Permanent`" = `"11:FALSE`"")
    $lines.Add("            `"SharedLegacy`" = `"11:FALSE`"")
    $lines.Add("            `"PackageAs`" = `"3:1`"")
    $lines.Add("            `"Register`" = `"3:1`"")
    $lines.Add("            `"Exclude`" = `"11:FALSE`"")
    $lines.Add("            `"IsDependency`" = `"11:FALSE`"")
    $lines.Add("            `"IsolateTo`" = `"8:`"")
    $lines.Add("            }")
}

if ($lines.Count -eq 0) {
    Write-Host "All plugins already referenced."
    exit 0
}

$newBlock = $nl + ($lines -join $nl)
$added    = $lines.Count / 21

# Insert before the closing brace of the File section
# The last plugin block ends with: "IsolateTo" = "8:"<nl>            }<nl>        }
$needle = '"IsolateTo" = "8:"' + $nl + '            }' + $nl + '        }'
$lastIdx = $content.LastIndexOf($needle)

if ($lastIdx -lt 0) {
    Write-Error "Could not find insertion point in .vdproj."
    exit 1
}

$insert   = '"IsolateTo" = "8:"' + $nl + '            }' + $newBlock + $nl + '        }'
$patched  = $content.Substring(0, $lastIdx) + $insert + $content.Substring($lastIdx + $needle.Length)

Copy-Item $vdprojPath "$vdprojPath.bak" -Force
[System.IO.File]::WriteAllText($vdprojPath, $patched)

Write-Host "Added $added plugin entries to the installer."
Write-Host "Backup saved to: $vdprojPath.bak"
Write-Host "Rebuild RawVideoCutterSetup in Visual Studio."
