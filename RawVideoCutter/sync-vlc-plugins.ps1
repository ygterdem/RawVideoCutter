param(
    [string]$BuildOutput = "$PSScriptRoot\bin\Release\libvlc\win-x64",
    [string]$SetupPluginsDir = "$env:USERPROFILE\Desktop\vlc-plugins"
)

$pluginsRoot = Join-Path $BuildOutput "plugins"

if (-not (Test-Path $pluginsRoot)) {
    Write-Error "Plugins folder not found at: $pluginsRoot"
    Write-Error "Build the project in Release configuration first."
    exit 1
}

# ── 1. Trim unused plugin folders from the Release build ─────────────────────
$removeFolders = @(
    "access_output", "lua", "logger", "keystore", "meta_engine",
    "mux", "services_discovery", "spu", "stream_extractor",
    "stream_filter", "stream_out", "text_renderer", "video_filter",
    "video_splitter", "visualization"
)

foreach ($folder in $removeFolders) {
    $path = Join-Path $pluginsRoot $folder
    if (Test-Path $path) {
        Remove-Item $path -Recurse -Force
        Write-Host "Trimmed: $folder"
    }
}

# From access/, keep only filesystem and attachment
$accessDir = Join-Path $pluginsRoot "access"
if (Test-Path $accessDir) {
    Get-ChildItem $accessDir -Filter "*.dll" |
        Where-Object { $_.Name -notin @("libfilesystem_plugin.dll", "libattachment_plugin.dll") } |
        ForEach-Object { Remove-Item $_.FullName -Force }
}

# ── 2. Flatten remaining plugins into the setup source folder ────────────────
New-Item -ItemType Directory -Force -Path $SetupPluginsDir | Out-Null

$copied = 0
Get-ChildItem $pluginsRoot -Recurse -Filter "*.dll" | ForEach-Object {
    $dest = Join-Path $SetupPluginsDir $_.Name
    Copy-Item $_.FullName $dest -Force
    $copied++
}

$sizeMB = [math]::Round((Get-ChildItem $SetupPluginsDir -Filter "*.dll" |
    Measure-Object -Property Length -Sum).Sum / 1MB, 1)

Write-Host ""
Write-Host "Done. Copied $copied plugin DLLs to: $SetupPluginsDir"
Write-Host "Total size: $sizeMB MB"
Write-Host ""
Write-Host "Now rebuild the RawVideoCutterSetup project in Visual Studio."
