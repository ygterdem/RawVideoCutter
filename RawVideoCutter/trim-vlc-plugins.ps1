param(
    [Parameter(Mandatory)][string]$PluginsRoot
)

# Entire folders not needed for local file preview
$removeFolders = @(
    "access_output",
    "lua",
    "logger",
    "keystore",
    "meta_engine",
    "mux",
    "services_discovery",
    "spu",
    "stream_extractor",
    "stream_filter",
    "stream_out",
    "text_renderer",
    "video_filter",
    "video_splitter",
    "visualization"
)

foreach ($folder in $removeFolders) {
    $path = Join-Path $PluginsRoot $folder
    if (Test-Path $path) {
        Remove-Item $path -Recurse -Force
        Write-Host "Removed: $folder"
    }
}

# From access/, keep only filesystem (local file reading)
$accessDir = Join-Path $PluginsRoot "access"
if (Test-Path $accessDir) {
    Get-ChildItem $accessDir -Filter "*.dll" |
        Where-Object { $_.Name -notin @("libfilesystem_plugin.dll", "libattachment_plugin.dll") } |
        ForEach-Object { Remove-Item $_.FullName -Force; Write-Host "Removed: access\$($_.Name)" }
}

$saved = [math]::Round((Get-ChildItem $PluginsRoot -Recurse -File |
    Measure-Object -Property Length -Sum).Sum / 1MB, 1)
Write-Host "Plugin folder now: $saved MB"
