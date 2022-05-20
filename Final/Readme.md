# Game Design Document - 3D Maze Game
## 🎮️ NAME OF GAME:
### Maze Game
## 👥 STAKEHOLDERS:
##### Developer: Muhammad Saqlain & Kanza Nawaz
##### Design: Riba,  Bushra & Sidra
##### QA: Muhammad Saqlain
## OVER VIEW
## 📐 PROJECT SCOPE
##### Budget: Internet Cost
##### Timeline: 3 Months
## 🗣️ELEVATOR PITCH
In this game we have a scenario like walls around the corners, we have a third person shooter that searches a path between these walls to complete the game and to arrive at the finish line from getting out of between these walls, simply that the person searches the path which he wants to go.
## 💵MONETIZATION:
Yes, we have a plan for the future to monetize a game that is we do App Ads between playing a game but we think it is a little bit annoying so we can make a purchase model like subscription for those users who have interest in playing a game. This monetization model often prevents users from downloading your game and gives you one-time revenue
## STORY:
The story of a maze game is that users have a third person character and have multiple paths which we make with glass walls. There is no big story in this game just to find the secret path between the glass walls.
## GAMEPLAY:
3D maze Game is a logic game that will help you to pass the time to find interesting and secret paths. A maze is a path or collection of paths, typically from an entrance to a goal. 
#### Object of the game: 
The object of the game is to get your maze runner through your maze collecting the sprites (paths) before the clock runs out of time
#### Target Goal:
A maze is a type of puzzle game where a player moves in complex and branched passages to find a particular target or location. 
## Features / Game Elements:
A maze is a structure surrounded by walls with numerous paths and passages, making it difficult for anyone to pass from one end of the maze to the other. Just like the actual maze, so we will develop a game which will have big walls as border to create confusion for the player.
1. First of all, you have to create the 3D plane on which the entire maze will reside.
2. Add materials and color to the game objects.
3. Add Third Person CHaracter and fit the camera with it
4. To add the walls (3D cubes), go to GameObject menu → 3D object → Cube.
5. Then add materials and texture on it.
6. Now adjust the size of the cube/wall according to your Character size (probably little bit larger than the size of the Character), increase the scale of Y coordinate or keeping Y coordinate intact, increase the X coordinate.
7. Design the maze structure by arranging the cubes on the 3D Plane, making the whole setup just like a maze.
8. We can use images & texture to make the maze walls and the 3D plane look more realistic.
9. You can download the wall texture (which is basically an image) and add it to the Assets pane by directly dragging the image from your desktop and dropping it onto any folder in the Asset pane.
10. Now, select that texture asset and drag it onto the walls to give your wall, a wall type look and the plane, a glassy feels.
11. Add Prefabs for what we doing multiple times.
12. Add sound features using download online sound in assets.
13. Add scripts for target the goal and move the character.
14. Add Animation in character.
15. Run the game using the play button.

## 👤 CHARACTERS:
Only one character to play this game using third person strategy.
## 🗺 LOCATIONS
In this game we have only 1 type of location that is the world to make with a glass walls and change the walls by upgrading the level of the game.
## 🏆 LEVELS / MISSIONS
There is only 2 levels of the game <br>
<b> Level 1 :</b> It is the easy level of our game there is only 60 to 80 sec of time limit and there is no hard walls to get a goal. User easily find the path in this time limit. <br>
<b> Level 2: </b> In this we can make a complicated path by using the walls to get confuse the user but we have a 120 sec of time limit that user identify his goal perfectly.<br>
<b> Mission: </b>  To identify the secret path to win a game.

## 📦 Scenes / Objects
There is 2 scenes as level1 and level 2, and for objects we have a character , walls, paths, times etc.
#### Scenes:
1. Start Screen
2. Level 1
3. Level 2
4. Quit Screen
5. Retry Screen
#### Objects:
7. Scenes
8. Assets
9. Transparent Walls
10. Third Person 
11. Level of the games
12. Paths
13. Timer
14. End Path

## ASSETS 
https://github.com/Sidra20870/GameDevelopment829-Spring2022/tree/main/Assign3/Assets 
https://github.com/Sidra20870/GameDevelopment829-Spring2022/tree/main/Assign3/Game%20Sound
https://github.com/Sidra20870/GameDevelopment829-Spring2022/tree/main/Assign3/Scenes

1. Materials of background and walls
2. Models of walls and person
3. Buttons
4. Animations
5. Sounds
6. Texture

## 🎨 ART
As using texture on the wall and character and using material on the scenes as well.
## 🏃‍ ANIMATION
1. Crouch
2. Jump Up
3. Jump Fall
4. Turn Right
5. Turn Left
6. Turn Sharp
7. Mid Air
## Video of the Game
https://github.com/Sidra20870/GameDevelopment829-Spring2022/tree/main/Assign3/Video%20Of%20The%20Game
## Sketches Of the Game

![WhatsApp Image 2022-05-07 at 10 08 17 AM](https://user-images.githubusercontent.com/61619271/167239378-de271696-c642-41f2-a153-a85240763626.jpeg)
![WhatsApp Image 2022-05-07 at 10 08 10 AM](https://user-images.githubusercontent.com/61619271/167239375-1eae2469-10f6-414e-a46e-d110b28de662.jpeg)

## Links
1. https://www.playworks.org/resource/game-of-the-week-the-maze-game/
2. https://www.studytonight.com/3d-game-engineering-with-unity/maze-game
3. https://apps.apple.com/us/app/puzzle-maze-games-3d/id1531864690
