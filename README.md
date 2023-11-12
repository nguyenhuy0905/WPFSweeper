# WPFSweeper
New MineSweeper attempt of mine.
Only run on Windows due to its framework.
Compared to my oldSweeper, this one is a lot cleaner, kind of better documented, and has some more features.
With some funny algorithms also.

---
### How-to: test and edit source code
I feel like I need to write this because of the framework I use. While you can try something different, this is what I am using
#### Set up Visual Studio
1. If you're not on Windows, set up a virtual machine that runs on Windows (I haven't tried other Windows versions yet,
but to be safe, use Windows 10/11). If I recall correctly, Visual Studio now only supports Windows (they used to support Mac. RIP) 
(But anyways, you're playing with a Windows-only framework after all)
2. Download and install Visual Studio 2022 (NOT Visual Studio Code). Here is a link to installation: [title](https://visualstudio.microsoft.com/downloads/)
3. In the installation options, select the following: **.NET desktop development**, then go to **Individual components**,
find and select **.NET 7.0 Runtime** (I guess if you have already downloaded the path, then you don't need to do this, but just
to be safe if you don't know what's going on (just like me)).
4. Clone the project into your device.
5. Have fun! *Viel spa�!*
### Context
#### Why did I start this?
* I wanted to code more. I finish school labs in like 3-4 hours, aka, each week I only have 3-4 hours of coding
hadn't I started this project.
* So that I have place to use C#. I have yet to learn so much about game-making, and I am quite afraid of
art designing. Sure, I can code games if I learn, but hell, I don't want to play a game with unintuitive graphics.
* It's fun. It's a nice way to see how much I have improved since my old Minesweeper project ([title](https://github.com/nguyenhuy0905/old-sweeper))
* I feel like I start to be a documentation fanatic. Even though I have tried to write self-documenting codes,
I still feel inside me the need to write looooooong documentations.
#### Anything I would like to improve, were I to do this all again?
* I will need to learn about Dependency Injection a lil bit more. Some cross-referencings in my code, while technically
valid, look extremely clunky. Also, DP will allow me to test everything much more easily; write a test class, and plug that
in instead of the usual class. Just like playing a jigsaw.
* Write this on a different, cross-platform framework. I am thinking something like MAUI.
#### Why the random German sentences here and there?
* Man, I'm trying to learn the language. *Ich kann gute Deutsche nicht.*
---
### The funny algorithms (to be) used
* Breadth First Search to open an area after the player clicks on the board for the first time.
* Breadth First Search to detect an area surrounded with mines, and then remove some mines from there.
---
### Notes
* Some of my old commits are outdated
* I don't use a graph node method anymore, though one commit said I do. This is replaced by Breadth-First Search.
### TODOs:
(started updating from Nov 11th)
This is a general list of what I am going to do next:
- [x] Add a timer
- [ ] Implement win/loss and popup window
- [ ] Format some methods to make them more test-able (by inserting different modules to it)
- [ ] Make a custom dialog box so that users can choose new game's difficulty, or load a saved game
- [ ] Finish serializer and deserializer (so that I can test the next method listed here)
- [ ] Implement the inspect grid method
- [ ] Make the interface look nicer
- [ ] Optional: connect thru LAN
---
### *Fragen?*
* I dunno, try to find my email and ask, if you can.
