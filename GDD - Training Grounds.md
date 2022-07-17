**Game – Training Grounds: First Person Shooter**

Created By- Jaspreet Singh             		



![](Aspose.Words.9cb52ffd-b658-4465-826b-13a6cb669c29.001.png)

1. # **Title Page**

1. ## **Game Name**

The name of the game is “Training Grounds”.

1. ## **Genre**

The game is a first person shooter game.

1. # **Game Overview**

1. ## **Game Concept**
Our game Training grounds is a single player fps shooter game with time control. The player uses the weapons provided to strategically shoot bots which are constantly moving on platforms in the least time possible. Game uses concepts like RayCasting, Collision, Destruction to provide the gameplay. The game ends when all bots are destroyed and player reaches the last checkpoint. 

1. ## **Target Audience**
Now, our game targets those players who want to play fps games for entertainment and test their skills in platforming and shooting in 3D level Design. The game is also competitive and contains a leaderboard.


1. ## **Genre(s)**
Our game belongs to platforming & first person shooter and also competitive genres. It consists of platforming through the level and shooting mechanics. Multiple weapons are used like assault rifles and sniper rifles.

1. **Look and Feel** 

The look and feel of the game is like a closed objective based realistic shooter. Contains realistic level design, skybox, lighting and base movement mechanics.
1. # **Gameplay**
   1. **Objective**: Main objective of the game is to strategically progress through the level by eliminating all the enemies hidden or otherwise moving on platforms and reaching the last checkpoint. The time control adds a competitive layer to the game, adding replayability and achievement by displaying best scores on leaderboard.

1. **Game Progression:** The game starts with the player at the spawn point in the beginning of the level. The player has 2 weapons which they can use to shoot enemy bots that are in several places in the game static, hidden or otherwise moving on platforms. The player traverses through the level shooting obstacles and bots and uses the movement mechanics to do 3D platforming to reach the last checkpoint which takes the player to the main menu and the best score is stored in the leaderboard.

1. **Mission/challenge Structure:** Challenge of the game to finish all enemy bots while platforming and reach the last checkpoint in the least possible time.

1. # **Mechanics (Key Section)**
   1. ## **Rules – What are the rules to the game**
The rules of the game are pretty simple. The player uses the weapons provided to shoot bots with 10 hp and each bullet damages 10hp per hit. If the player falls off while platforming they respawn at the beginning of the level. The timer stops when the player defeats all bots and reaches the last checkpoint. The player moves using the W,A,S,D keys simulating forward, backward, left and right movement. Left-click is used to shoot and Right-click to use iron sights inside the game. SHIFT to run and space to jump.

1. ## **Model of the game universe.**
The game is modeled as a time control fps with platforming elements. On a closed strategic level. Which can be traversed progressively with realistic lighting. The player is a humanoid with weapons and the enemies are bots performing different actions.

1. ## **Physics – How does the physical universe work?**
The physics of the world is similar to actual world physics in terms of the amount of gravity, laws of motion etc. The game gives realistic sounds when shooting with muzzle animations and reloads. Some liberties are taken with respect to the player movement making the player more agile and jump higher. The platforms also float in the sky.

##
## **4.6. Combat – If there is combat or even conflict, how is this specifically modeled?**

The actions of the game character include the basic first person shooter with platforming elements. The combat just simulates a level based gun range with time control.The player moves using the W,A,S,D keys simulating forward, backward, left and right movement. Left-click is used to shoot and Right-click to use iron sights inside the game. SHIFT to run and space to jump. The player uses these mechanics to strategically shoot bots which have 10hp while the gun projects 10hp damage. 

1. # **Game World**
   1. ## **General look and feel of world**
The game has a level design which feels office-like. The level is suspended in the sky and contains elements of platforming.

1. **Main Area**

![](Aspose.Words.9cb52ffd-b658-4465-826b-13a6cb669c29.002.png)


1. # **Characters**

1. ## **List of Characters**

1. Protagonist: The player of this game in first person mode with weapons. The player has a body modeled with just hands and guns. The main game camera is inside this game object.

![](Aspose.Words.9cb52ffd-b658-4465-826b-13a6cb669c29.003.png)

![](Aspose.Words.9cb52ffd-b658-4465-826b-13a6cb669c29.004.png)

1. Bots: The game has a simple bot modeled as a humanoid structure but no skin. There are multiple types of bots in the game which all have different types of animations. The player has to eliminate all these bots with hit boxes modeled as the humanoid structure. There are 4 types of bots in the game based on their animations.

`                        `Taunt Bot                                               Defeated Bot![](Aspose.Words.9cb52ffd-b658-4465-826b-13a6cb669c29.005.png)![](Aspose.Words.9cb52ffd-b658-4465-826b-13a6cb669c29.006.png)

`	            `Praying Bot                                             Rumba-Dancing Bots![](Aspose.Words.9cb52ffd-b658-4465-826b-13a6cb669c29.007.png)![](Aspose.Words.9cb52ffd-b658-4465-826b-13a6cb669c29.008.png)



1. ## **Artificial Intelligence Use in Opponent and Enemy**

The bots are on platforms that have randomized motion to make them harder to hit and add difficulty to the game.

7. # **Levels**
   1. ## **Details of what happens in the level**
      1. **Map**

`	`**![](Aspose.Words.9cb52ffd-b658-4465-826b-13a6cb669c29.009.png)**

` `**Hallway ‘Room 1’**

![](Aspose.Words.9cb52ffd-b658-4465-826b-13a6cb669c29.009.png)

`  `**‘Room 2’**

![](Aspose.Words.9cb52ffd-b658-4465-826b-13a6cb669c29.010.png)

`  `**‘Room 3’**

![](Aspose.Words.9cb52ffd-b658-4465-826b-13a6cb669c29.011.png)

`  `**Last Checkpoint** 

1. ## **Path that the player takes**
After spawning on the beginning of the level the player follows the hallway in the beginning while eliminating halls into ‘room 2’ which is a big hall with bots in different directions. Then the player shoots the mirrors blocking his path into ‘room 3’ where other bots are present on platforms. Finally the player jumps past the moving platforms to reach the last checkpoint.
