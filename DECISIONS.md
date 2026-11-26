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

## 2026-11-26 — The first sink: an Extra Jar upgrade, base 80, growth 1.5, max 3
- **Options:** extra time per level / an extra jar / a bigger coin reward per level / new jar themes
- **Chose:** an Extra Jar upgrade. Each level of the upgrade gives one more Extra Jar use in every level. Base cost 80, growth 1.5, max level 3.
- **Why:** in the sort games I played, coins bought an extra jar or more time when I was stuck. Color Jar has no timer, so the extra jar fits the game as it is (it's already a helper in my pitch). Max 3 and a growing price answer the feedback on my pitch: helpers stay limited, so buying them doesn't make levels trivial. With 50 coins a level and about 2 levels a session, base 80 gives the first upgrade in the first session and the next ones every 1–2 sessions, so both checks in the economy sheet say Yes.
- **Later:** I'd rather the extra jar be bought inside a level only when I need it and gone after the level. For this milestone I kept a permanent upgrade, because the sink has to be remembered after closing the app. Timed levels are also an idea for the final game, and then extra time could be a second sink.
- **AI:** Claude suggested a few options and the first numbers; the ideas of extra jar or extra time came from games I played, and I chose the extra jar and the max of 3.
- **Who:** Seba Amasha

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