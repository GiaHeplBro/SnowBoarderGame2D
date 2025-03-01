#  Snowboarding Unity Game ( Deployment and Technical Overview )

## **1. Deployment Process of this 2D Unity Game**

I followed the tutorial "Create a 2D Snow Boarder Game with Unity and" from SK Courses Lab to deploy my Snowboarding 2D Unity game. There are multiple platforms available for deployment, but I chose itch.io as my primary platform. Once deployed, I received a direct itch.io link to share with others so they can try out the game.

👉 My docs about this game: [https://docs.google.com/document/d/1AfZ7cpvOqMElzkoVl3Mf8bt2oXCWR5cY7EBX5GvljrE/edit?usp=sharing]

👉 My itch.io account: [https://giaheplbro.itch.io/]

This is the game Menu and UI. It includes one of the levels.

![image](https://github.com/user-attachments/assets/c7cf0a5e-f9e0-464c-94db-f0644dfc3d2d)


And this is when the player crashes.

![image](https://github.com/user-attachments/assets/49367d11-fa8d-4c6d-a7a1-c20270378c0f)

### **Disclaimer:**
This 2D Unity game is currently designed for **PC and laptop** only, as it relies on keyboard input for movement. It does not support touchscreen controls yet, but I plan to add mobile support in future updates.

---

# **Snowboarding 2D Unity Game Development Report**

## **1. Game Idea**
The design of this 2D snowboarding game is inspired by classic **endless runners** and **extreme sports games** like **SSX Tricky** and **Alto’s Adventure**. The focus is on smooth movement, physics-based gameplay, and performing tricks while navigating an icy terrain.

### **Inspirations for the Game:**
#### **Extreme Snowboarding Games:**
- Smooth controls and responsive physics-based movement.
- Trick-based mechanics for extra points.
- Obstacle-based progression (trees, rocks, gaps).

#### **Casual Arcade Games:**
- Simple controls with increasing difficulty.
- Endless and level-based modes.
- High-score tracking for replayability.

## **2. Game Features**

Core Mechanics:

Jumping & Movement: The player can jump and move left or right while in the air.

Scoring System: Points are earned based on successful tricks and reaching checkpoints.

Obstacles & Environment:

Foggy Areas: Reduce visibility, adding difficulty.

Ice Patches: Cause the player to slide further.

Aerial Hazards: Birds may appear and interfere with movement.

Endless Run: The game consists of a single level, but the challenge is to earn as many points as possible before reaching the goal.

Planned Features (Future Updates):

Star Collection: Players can collect stars for additional points.

Advanced Trick System:

Pressing specific keys mid-air will execute tricks.

Combining tricks into sequences will result in bonus points.

Longer Levels: Expanded terrain with more diverse challenges.

Multiple Game Modes: Different difficulty settings and challenges.

## **3. Game Development Process**

Project Setup & Tools Used:

Game Engine: Unity

Programming Language: C# (via Visual Studio)

Version Control: GitHub

Audio Assets: Free NoCopyright music

Folder Structure:

Contents of the 'Assets' Folder:

  Scripts:
  
        Contains all scripts handling movement, enemy behavior, and UI updates.
        
        Scripts were initially generated with ChatGPT’s help and later refined through debugging.
        
  Sounds:
  
        Contains background music sourced from NoCopyright libraries.
        Music is set to loop.
  Scenes:
  
        Stores the Main Menu scene and Scene mission.
  Picture:
  
        Contains tag, snow, and backround picture.
  Pretabs:
  
        Contains all tab use replay.
  AssetStore:
  
        Contains backround picture from asset store.
        Some sprites were sourced from free asset websites, while others were edited in Pain2D.
  Sprites:
  
    Contains all Sprites to do.


Development Steps:

Basic Player Controls:

Implemented movement and jumping.

Physics Interactions:

Added environmental effects like sliding on ice and obstacle collisions.

UI & Score System:

Display score based on performed tricks and collected items.

Fog Mechanic:

Implemented moving fog that affects visibility.

Testing & Debugging:

Playtested controls and adjusted physics for better balance.

## **4. Deployment & Version Control**

The game is managed using GitHub for version control.

Future plans include deployment on itch.io to allow public access.

## **5. Future Plans**

Refine trick system to allow complex combinations.

Add AI-based challenges such as racing against an opponent.

Optimize performance for better gameplay experience.

Introduce leaderboard functionality to track high scores globally.
## **6. Sources & References:**
- Create a 2D Snow Boarder Game with Unity and C# (https://www.youtube.com/watch?v=M2HWCXOcTm4&t=547s)
- Have use Snow-boarder Code (https://github.com/justindstein/snow-boarder/tree/main)
- ChatGPT (For initial C# script generation and debugging assistance)

---

## **7. Technicalities Between Unity and GitHub**

To manage version control, I uploaded the project to GitHub. The tutorial "How to Upload Unity Projects to GitHub" by GDTitans (https://www.youtube.com/watch?v=YymhtHtHDb8) explains the process clearly.

### **Git Ignore in Unity**
GitHub automatically ignores unnecessary files. The `.gitignore` file for Unity excludes:
```
/Library/
/Logs/
/UserSettings/
/Temp/
/Build/
```
These folders are not needed because Unity regenerates them automatically.

### **How to Download and Open This Unity Project from GitHub**
To download and open the game in Unity, I followed the tutorial "How to import GitHub projects into Unity!" by Unity Hero (https://www.youtube.com/watch?v=I9QK_2QW9W8).

