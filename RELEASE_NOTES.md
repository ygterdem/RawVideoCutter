# Release Notes

---

## v1.0.2 — 2026-05-06

### New features

#### Discord upload helper
- **Split for Discord** — after exporting, automatically splits the clip into parts of any size (default 25 MB for free Discord, 500 MB for Nitro)
- **Re-encode to H.264 (Discord)** — converts HEVC/H.265 source footage to H.264 so Discord shows an inline video preview instead of a plain file icon; also makes split sizes very accurate since H.264 has frequent keyframes
- Split and re-encode options are independent: you can re-encode a single clip without splitting, or split a lossless clip without re-encoding

#### Quick-access buttons
- **📁 Open Folder** — opens the export destination in Windows Explorer with one click
- **▶ Open Last Video** — opens the most recently exported clip in your default video player; enabled automatically after each export (points at `_part01` when splitting was used)

### Fixed
- **Split controls overlapping CUT END timebox** — moved the Split / Re-encode row to its own dedicated line below the cut-point controls; no more cramped layout

---

## v1.0.1 — 2026-04-20

### Fixed
- **Maximize button now resizes the full layout** — all controls (video view, seek bar, progress bar, export folder row, cut-point controls) were using absolute positions with no anchor rules. Added `Anchor` properties to every control so clicking □ expands the video view to fill available space while bottom controls stay pinned to the bottom and right-side controls stay pinned to the right edge.
- **Play and Export buttons re-centre on resize** — added an `OnResize` override that keeps the ▶ Play, ⬇ Export Cut, and current-time label dynamically centred in the content area at any window width.

---

## v1.0.0 — 2026-04-19

### New features

#### Combined single-screen layout
- Merged the folder browser and cutter into one unified screen — no more tab switching
- App width increased to 1280 × 812 to give the video preview more room

#### Keyboard shortcuts
- `Space` — play / pause
- `[` — set cut start at current position
- `]` — set cut end at current position
- `←` / `→` — step one frame back/forward (when paused) or seek ±5 s (when playing)
- `Shift+←` / `Shift+→` — seek ±30 seconds

#### Seek bar upgrades
- **Audio waveform** — ffmpeg `showwavespic` renders a waveform PNG into the seek bar so you can find cuts by sound without scrubbing
- **In/out point markers** — green and red triangles on the seek bar show exactly where your cut starts and ends
- **Shaded cut region** — the selected range is highlighted in the seek bar

#### Auto-advance
- After a successful export, the next video in the folder list is automatically loaded and selected

#### Premium font overhaul
- All labels, buttons, and text boxes switched to Segoe UI / Consolas at tuned sizes for a cleaner look

#### Custom frameless window chrome
- Removed the system title bar; replaced with a custom dark title bar (18, 18, 18)
- Minimise (─), maximise (□/❐), and close (✕) buttons with hover highlights
- Window drag via the title bar using Win32 `WM_NCLBUTTONDOWN`
- 1 px subtle border painted around the window edge
- Drop shadow via `CS_DROPSHADOW`

### Fixed
- Progress bar was overlapping the "Export Progress" and "Remaining Time" labels — separated into distinct rows with proper vertical spacing

### Installer
- Desktop shortcut correctly created on install
- All VLC plugins and ffmpeg bundled — no external dependencies required
