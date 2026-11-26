# AGENTS.md: context for AI coding tools

## The game
Color Jar: a Water Sort style puzzle. Tap a jar to pick it, then tap another jar to pour the top color into it. Sort every color into its own jar to finish the level. Levels take 1–3 minutes. The player earns coins for finishing levels and spends them on helpers (Undo, an extra jar) and on new jar themes. Android, portrait, one thumb.

## Architecture
- Unity project: `ColorJar/`
- Scenes (`Assets/Scenes`): Bootstrap (first in the Scene List, starts the services, no UI) → Home ⇄ Level
- Services (`Assets/Scripts/Services`), started in Bootstrap in this order:
  1. Save: `ISaveService` → `PlayerPrefsSaveService`
  2. Config: `IConfigService` → `ScriptableObjectConfigService`, which holds `EconomyConfig` (`Assets/Config/EconomyConfig.asset`, dragged into Bootstrap in the Inspector)
  3. Settings: `ISettingsService` → `SettingsService` (SoundOn), saved through `ISaveService`
- Every script finds the services through the static class `Services` (`Services.Save`, `Services.Config`, `Services.Settings`).
- Screens use `Services`, never `PlayerPrefs` directly. Only `PlayerPrefsSaveService` touches `PlayerPrefs`.
- Every economy number (rewards, prices, the upgrade curve) lives in `EconomyConfig`. No economy numbers in scripts.
- Economy: Level won → `coinsPerLevel`. Sink: the Extra Jar upgrade in Home (`UpgradeButton`), price `UpgradeCost(level)` = base × growth^level, up to `upgradeMaxLevel`, saved under `extra_jar_level`. Level shows the Extra Jars it gets (`ExtraJarsLabel`).
- Win and Lose in Level are stand-in buttons (`LevelResult`) until the real pour-and-sort code exists.
- Two assemblies: `Game` (screens and gameplay) references `Services`. `Services` never references `Game`.
- `Assets/Editor/PlayFromBootstrap.cs` makes every Play in the editor start from Bootstrap.

## Rules for AI
- Don't change Player Settings, the package name or API levels.
- Don't invent APIs. If unsure, say so and point to the official docs.
- New services go behind an interface in `Services` and are started in Bootstrap, in order.
- Keep changes small. Say what you changed and why. Change nothing you were not asked to.