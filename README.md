# Unity2D_SaigonStreetRunner_Lab01

## Overview
Unity2D_SaigonStreetRunner_Lab01 is a simple endless runner game built with Unity 2D. The player controls a character running through Saigon streets, avoiding obstacles and collecting power-ups to achieve the highest possible distance.

---

## Controls

- **Jump:** `Up Arrow` (when on ground)
- **Activate Speed Power-Up:** `Left Shift` (when available)
- **Cheat Code (Enable Hack Mode):** Press `Left Arrow`, `Left Arrow`, `Right Arrow`, `Down Arrow`, `Up Arrow` in sequence
- **Cheat Code (Disable Hack Mode):** Press `Down Arrow`, `Up Arrow`, `Left Arrow`, `Right Arrow` in sequence
- **Pause/Resume/Exit:** Via UI buttons or `Escape` in menus

---

## Scene Structure

- **Main Menu Scene:** Handles game start, settings, instructions, and credits.
- **Game Scene:** Core gameplay, including player, obstacles, power-ups, UI, and game management.
- **UI Elements:** Managed via Unity UI and TextMeshPro for score, distance, and overlays.

---

## Prefabs

- **Player:** Main character with movement, animation, and collision scripts.
- **ObstaclePrefab:** Array of obstacle prefabs spawned during gameplay.
- **EatPrefab:** Array of collectible/power-up prefabs (e.g., speed boost).
- **UI Prefabs:** Buttons, overlays, and labels for menus and in-game UI.

---

## How to Build & Run

1. **Open Project:**  
   Open the project folder in Unity (recommended version: 2021.3 LTS or newer).

2. **Scenes:**  
   Ensure the main menu and game scenes are added to the build settings (`File > Build Settings`).

3. **Build:**  
   - Go to `File > Build Settings`.
   - Select your target platform (e.g., PC, Mac & Linux Standalone).
   - Click `Build` and choose an output directory.

4. **Run:**  
   - After building, run the generated executable.
   - Or, press `Play` in the Unity Editor to test directly.

---

## Notes

- All scripts are located under `Assets/Scripts/`.
- Prefabs are referenced in the `GameManager` and related managers.
- For best experience, play in 16:9 aspect ratio.

---

Enjoy running through Saigon streets!
