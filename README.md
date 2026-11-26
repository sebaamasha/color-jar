# Color Jar

**Team:** Seba Amasha · **Course:** Mobile Game Development, Shenkar

## The game in one sentence
Pour colors between jars to sort each color into its own jar, and come back every day for a daily coin reward and new jar themes to unlock.

## How to open and build
1. Open the project in Unity 6 LTS (the exact version is on Moodle).
2. File → Build Profiles → Android → Switch Platform.
3. Build and run on an Android phone.

## Repo map
| File | What it is |
|---|---|
| `pitch.md` | One-page pitch of the game |
| `DECISIONS.md` | Every real decision the team made, and why |
| `AGENTS.md` | Context for AI coding tools: architecture, rules, conventions |

## Architecture
Scenes, services and init order:

```mermaid
flowchart LR
    B["Bootstrap<br/>scene 0, no UI"] -->|"1 · Save"| S1["ISaveService<br/>→ PlayerPrefsSaveService"]
    B -->|"2 · Config"| S2["IConfigService<br/>→ ScriptableObjectConfigService<br/>(EconomyConfig.asset)"]
    B -->|"3 · Settings"| S3["ISettingsService<br/>→ SettingsService (SoundOn)"]
    S3 -->|saves through| S1
    B -->|"then loads"| H["Home<br/>scene 1"]
    H -->|Play| L["Level<br/>scene 2"]
    L -->|"Win (+coins) / Lose / Back"| H
```

Two assemblies: **Game** (Bootstrap, ScreenFlow, CoinCounter, SoundButton, UpgradeButton, LevelResult, ExtraJarsLabel, SafeAreaFitter) → **Services** (ISaveService, PlayerPrefsSaveService, IConfigService, ScriptableObjectConfigService, EconomyConfig, ISettingsService, SettingsService, Services). Services never references Game.


## Economy
- Economy sheet: [Color Jar – Economy sheet](https://docs.google.com/spreadsheets/d/11NBfF-GjFemjhJcRl-Lgsii-D6ruwureKFjtRiFAJ14/edit?usp=sharing)
- Every economy number lives in `ColorJar/Assets/Config/EconomyConfig.asset`, read through `Services.Config.Economy`.
- Sources: 50 coins per level won, about 2 levels per session.
- Sink: the Extra Jar upgrade (one more Extra Jar per level), base cost 80, growth 1.5, max level 3.

## Art
Where every image comes from: [CREDITS.md](CREDITS.md)