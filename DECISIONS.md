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
## 2026-11-03 — Game direction: a Water Sort puzzle ("Color Jar")
- **Options:** Water Sort / Tile Match / Stack / Block Blast / Parking Jam
- **Chose:** Water Sort
- **Why:** I'm working alone and this is my first game, so I wanted something challenging but realistic to finish. Water Sort has simple tap controls that fit one thumb, clear levels and goals, and the main work is in the logic and the data (pour rules, win check, level data, and maybe generating solvable levels), which fits a software engineering course.
- **AI:** Claude suggested several genres and ranked them by difficulty for a solo beginner; I compared them and chose Water Sort myself.
- **Who:** Seba Amasha