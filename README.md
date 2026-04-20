# Raw Video Cutter

A lightweight Windows desktop tool for quickly trimming raw video files without re-encoding. Built with C# / WinForms and powered by LibVLC (preview) and ffmpeg (lossless cutting).

![Platform](https://img.shields.io/badge/platform-Windows-blue) ![Framework](https://img.shields.io/badge/.NET-4.8-purple) ![License](https://img.shields.io/badge/license-MIT-green) ![Release](https://img.shields.io/github/v/release/ygterdem/RawVideoCutter)

---

## Features

- **Lossless cutting** — trims video using `ffmpeg -c copy`, no re-encoding, instant exports
- **Built-in preview player** — plays video directly in the app via LibVLC
- **Combined single-screen layout** — folder browser and cutter live on one screen, no tab switching
- **Custom seek bar** — click or drag to scrub; displays an audio waveform so you can cut by sound
- **In/out point markers** — coloured triangles on the seek bar show exactly where your cut starts and ends
- **Keyboard shortcuts** — `Space` play/pause · `[` set start · `]` set end · `←/→` step frame · `Shift+←/→` ±30 s
- **Audio track selector** — choose which audio track to preview and export
- **Fullscreen preview** — watch the full video before cutting; press `Esc` or `F11` to return
- **Auto-advance** — after exporting, automatically loads the next video in the folder
- **Auto-named exports** — clips are saved as `<original_name>.mp4` in your chosen export folder
- **Export folder memory** — remembers your export destination between sessions
- **Delete originals** — remove source files from disk directly from the sidebar
- **Progress bar** — live export progress with estimated time remaining
- **Custom frameless chrome** — dark title bar with minimise · maximise · close; fully resizable
- **Drop shadow & window border** — polished borderless-window look
- **Desktop shortcut** — installer places a shortcut on your desktop

---

## Screenshot

> Load a folder → pick a clip → set start/end → export. All on one screen.

---

## Installation

1. Download the latest **RawVideoCutterSetup.msi** from the [Releases](../../releases) page
2. Run the installer — it includes all required VLC libraries and ffmpeg
3. Launch **Raw Video Cutter** from the desktop shortcut or Start Menu

> No additional software required. VLC and ffmpeg are bundled.

---

## Usage

### Cutting a video

1. Click **Browse** in the sidebar, pick your raw video folder, then double-click a file to load it
2. Use the seek bar or arrow keys to find your start point → press `[` or click **[ Set**
3. Scrub to your end point → press `]` or click **Set ]**
4. Click **⬇ Export Cut** — the trimmed clip is saved to your export folder as `<original_name>.mp4`

### Keyboard shortcuts

| Key | Action |
|-----|--------|
| `Space` | Play / Pause |
| `[` | Set cut start at current position |
| `]` | Set cut end at current position |
| `←` / `→` | Step one frame (paused) or ±5 s (playing) |
| `Shift+←` / `Shift+→` | Seek ±30 seconds |
| `F11` / `Esc` | Toggle fullscreen video preview |

### Setting an export folder

Click **📂 Select Folder** next to the export path. The folder is remembered for future sessions.

### Fullscreen preview

Click the **⛶ Fullscreen** button (top-right) or press `F11`. Press `Esc` or `F11` again to return to the editor.

### Deleting originals

Select a video in the sidebar and click **🗑 Delete Selected** to remove the source file from disk.

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

## Changelog

See [RELEASE_NOTES.md](RELEASE_NOTES.md) for the full version history.

---

## License

MIT — see [LICENSE.txt](LICENSE.txt)
