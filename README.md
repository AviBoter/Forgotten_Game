# Forgotten_Game

Castle Wolfenstein.
 
 As a part of our class assignment we decided to tribute game that inspired id Software's blockbuster Wolfenstein 3D - 
 game which many people termed as the "grandfather of 3D shooters" and widely considered to be one of the greatest video games ever made.
 One of a few games that change Gaming History!
 
 We required to transfrom an old abndoned game (Castle Wolfenstein) to a 2D tiles game.
 
 ### Original game here: https://www.myabandonware.com/game/castle-wolfenstein-3l
 
 ### our base code from: https://github.com/gamedev-at-ariel/05-tilemap-pathfinding
 
 ### game tiles from here: https://github.com/jahshuwaa/u4graphics
 
 ### itch.io upload of our the game here: https://lba-universe.itch.io/forgotten-game
 
 Our Game's plot:
 
 You playing a witcher who search his way home in hustle area, in those days witchers were hunted.
 so you must fight back to survive till you get home don't let them catch you, and try dodge the ships bullets.

 Keys:

 Movement - using the Arrows

 FireBall  - using the keys w,a,s,d for shoting in require direction

 Walk into hot ballon,hills by mining them, or getting into home - using Space ## ( Note please press Space then walk through them).
 
 Enjoy!
 
 Scripts Changed:
 KeyboardMoverByTile - adding player the ability the mine through tiles and transform himself with game's veriuos types of shortcuts ways.
 In case of mining, a mountain tile was mined becomes a grass (can be changed easily by designer).
 [link here:](https://github.com/Lba-universe/Forgotten_Game/blob/master/Assets/Scripts/2-player/KeyboardMoverByTile.cs)
 
 DestoryOnTrigger2D.cs - using it on few diffrent objects, destory both objects that collides on giving tag 
 [link here:](https://github.com/Lba-universe/Forgotten_Game/blob/master/Assets/Scripts/3-enemies/DestoryOnTrigger2D.cs)
 
 Chaser.cs - modify base script, when the enemy is close to our player by given radius -> player lost so restart the scene
 [link here:]( https://github.com/Lba-universe/Forgotten_Game/blob/master/Assets/Scripts/3-enemies/Chaser.cs)
 
 AttackSpawner.cs - spawns given object whenever the player clicks a given keys - used to generate fireballs for the player
 there is also a cooldown attack field to make the game bit harder
 [link here:](https://github.com/Lba-universe/Forgotten_Game/blob/master/Assets/Scripts/2-player/AttackSpawner.cs)
 
 FireBallMover.cs - attached to object that spawn by "AttackSpawner script" - used to set the direction of the fireball
 [link here:](https://github.com/Lba-universe/Forgotten_Game/blob/master/Assets/Scripts/2-player/FireBallMover.cs)
 


 ###
 
 ## pics:
 
 ![](https://github.com/Lba-universe/Forgotten_Game/blob/master/pics/pic2.png)

 ![](https://github.com/Lba-universe/Forgotten_Game/blob/master/pics/game1.png)
 
 
