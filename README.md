# Raw Video Cutter

A lightweight Windows desktop tool for quickly trimming raw video files without re-encoding. Built with C# / WinForms and powered by LibVLC (preview) and ffmpeg (lossless cutting).

![Platform](https://img.shields.io/badge/platform-Windows-blue) ![Framework](https://img.shields.io/badge/.NET-4.8-purple) ![License](https://img.shields.io/badge/license-MIT-green)

---

## Features

- **Lossless cutting** — trims video using `ffmpeg -c copy`, no re-encoding, instant exports
- **Built-in preview player** — plays video directly in the app via LibVLC
- **Custom seek bar** — click or drag to scrub through the video
- **Set in/out points** — mark start and end times with a button press at the current position
- **Folder browser tab** — load a folder of raw videos and pick files from a list
- **Auto-named exports** — exports are automatically named after the source file as `.mp4`
- **Export folder memory** — remembers your export destination between sessions
- **Fullscreen preview** — press the fullscreen button to watch the full video before cutting
- **Delete originals** — delete source files from the folder list after cutting
- **Progress bar** — shows export progress and estimated remaining time
- **Desktop shortcut** — installer places a shortcut on your desktop

---

## Installation

1. Download the latest **RawVideoCutterSetup.msi** from the [Releases](../../releases) page
2. Run the installer — it includes all required VLC libraries and ffmpeg
3. Launch **Raw Video Cutter** from the desktop shortcut or Start Menu

> No additional software required. VLC and ffmpeg are bundled.

---

## Usage

### Cutting a video

1. Go to the **Folder** tab, browse to your raw video folder, and double-click a video to load it
2. Use the seek bar or playback controls to find your start point → click **Set Start**
3. Scrub to your end point → click **Set End**
4. Click **Export** — the trimmed clip is saved to your export folder as `<original_name>.mp4`

### Setting an export folder

Click **Select Export Folder** on the Cutter tab. The folder is remembered for future sessions.

### Fullscreen preview

Click the **Fullscreen** button to open the video in a maximised window. Press `Esc` or `F11` to exit.

### Deleting originals

Select a video in the Folder tab and click **Delete** to remove the source file from disk after cutting.

---

## Building from Source

### Requirements

- Visual Studio 2019 or later
- .NET Framework 4.8
- NuGet packages (restored automatically): `LibVLCSharp`, `LibVLCSharp.WinForms`, `VideoLAN.LibVLC.Windows`

### Steps

```
git clone https://github.com/ygterdem/RawVideoCutter.git
cd RawVideoCutter
```

Open `RawVideoCutter.sln` in Visual Studio and build in **Release | x64**.

A post-build script (`trim-vlc-plugins.ps1`) automatically removes unused VLC plugins from the output folder to keep the build lean.

### Building the installer

1. Build the main project in **Release | x64** first
2. Run `sync-vlc-plugins.ps1` to flatten the trimmed plugins to `%USERPROFILE%\Desktop\vlc-plugins\`
3. Run `patch-vdproj-plugins.ps1` to register all plugin DLLs in the setup project
4. Rebuild **RawVideoCutterSetup** in Visual Studio

---

## Tech Stack

| Component | Library |
|-----------|---------|
| UI framework | WinForms (.NET 4.8) |
| Video preview | [LibVLCSharp](https://github.com/videolan/libvlcsharp) 3.9.3 + VideoLAN.LibVLC.Windows 3.0.21 |
| Video cutting | ffmpeg (bundled, stream copy) |
| Installer | Visual Studio Setup Project (.vdproj) |

---

## License

MIT — see [LICENSE.txt](LICENSE.txt)
