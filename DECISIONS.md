# Decision log

Add an entry every time the team makes a real choice: a tool, a design, a trade-off.
About 1–2 entries a week. Newest at the top. Write the reasoning yourselves; AI may fix the wording.

## Template
```
## YYYY-MM-DD — [The decision, in a few words]
Options: [A] / [B] / [C]
Chose: [what] — [why]
AI: [what the AI suggested, and what you did with it — or "not used"]
Who: [name(s)]
```

## Example
```
## 2026-11-20 — Save progress locally first
Options: PlayerPrefs / JSON file / Cloud Save
Chose: JSON file now, Cloud Save later
Why: works offline, easy to move later
AI: suggested a SQLite database — rejected, too heavy for one save file
Who: Yuval
```

---

<!-- Your entries start here -->
## 2026-11-19 — Save goes through an interface (ISaveService)
- **Options:** call PlayerPrefs directly from every screen / one ISaveService interface with a PlayerPrefs implementation behind it
- **Chose:** ISaveService, with PlayerPrefsSaveService today
- **Why:** screens only know the contract (GetInt / SetInt), not how saving works. Later in the course progress moves to cloud save: I write one new class and change one line in Bootstrap, and no screen changes. It also means only one class touches PlayerPrefs, so the settings service saves through the same interface instead of having its own way to save.
- **AI:** Claude explained the pattern from the Lesson 3 slides and wrote the code with me; I chose to keep it this way and checked that coins and the sound setting survive closing the game.
- **Who:** Seba Amasha


## 2026-11-03 — Game direction: a Water Sort puzzle ("Color Jar")
- **Options:** Water Sort / Tile Match / Stack / Block Blast / Parking Jam
- **Chose:** Water Sort
- **Why:** I'm working alone and this is my first game, so I wanted something challenging but realistic to finish. Water Sort has simple tap controls that fit one thumb, clear levels and goals, and the main work is in the logic and the data (pour rules, win check, level data, and maybe generating solvable levels), which fits a software engineering course.
- **AI:** Claude suggested several genres and ranked them by difficulty for a solo beginner; I compared them and chose Water Sort myself.
- **Who:** Seba Amasha