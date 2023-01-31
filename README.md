# Xeriscape
 A game made in the GGJ 2023 theme, 'roots', in under 48 hours.
 
 ## Controls and objective: 
 The point of the game is to keep your plant alive for as long as possible by destroying the incoming apples. Use the mouse to control the roots of the plant, and left click to boost (without boosting, you won't have enough speed to destroy the apples). There is also a worm somewhere in the game which will heal the plant, but this can only be used once. 
 
## Report:
 My first idea for the game jam was built around the idea controlling the roots of a plant, where you need to descend into the Earth as far as possible to find water, whilst avoiding rocks. This would have been procedurally generated, and the user would gain score for the distance they managed to travel. However, I was unsure about the procedural generation of the game, and I don't think I could have made the camera move as smoothly as I was envisioning. Instead of this, I had a new idea, where the player would instead use the roots to attack things above the surface and use their nutrients to grow. I had ideas about the roots impaling the enemies, engulfing them, and being able to see wherabouts in the root this food source had gone (whilst it travelled back towards the plant), though I knew I wouldn't really be able to do this, especially not in 2 days ( I didn't even know how to make the roots yet) , but this didn't put me off of the idea of the game. 
 
 First off, I created the basic sky, the ground, the flower and the root objects, soon to realise that I didn't know where to go next, and that my game did nothing at all. I had also made all of this incredibly small, at a scale of around 0.02, as I thought that it made sense since plants wouldn't be huge, but didn't realise that this would cause issues later on... I was eager to create the roots based on my first idea of them, and began to look for guides on how to do this, luckily finding a video on procedural animation for tendrils using line renderers, which suited my needs almost precisely. The video I used also went through how to make the character follow the mouse, which helped aswell. The first issue that I came across due to my use of scale was that my tendrils, however, were just giant circles and in the wrong place, and I ended up spending alot of time trying to fix this - in the end, I figured out that I could simply change the scale of the line render, and the positioning sort of ennded up fixing itself via positioning in the script. I also tried to add wiggling to the roots, but I believe the scale prevented this too, as the first line render would simply vibrate, and the rest wouldn't move. 
 
 From here I had built up momentum and did alot of the game by myself, granted with lots of trial and error, making the enemies, enemy movement, stamina, health, a gravity trigger when the user touches the sky (as, surprisingly, it hadn't before occurred to me that the player would follow the mouse through the sky like it was the ground), etc. I also wanted a spawn system for the enemies, so that they would continously appear over time, which is where I ran into another big issue. I find referencing in Unity confusing, and I thought I had gotten used to it with this project ( I had figured out the idea of creating a public variable for a script, for example, and then drag/dropping the corresponding object in the editor) until it came to using prefabs for a spawning system, where it turns out that prefabs can't keep their references. I had read that you can get around this by using a "find" in the spawner, and then using the spawner to pass on these variables to the instanced objects, but I couldn't figure out how this worked, and when I thought I had got it with no errors showing up, nothing happened in the game itself. I ended up re-making all of the public variables for each reference and manually putting them on the spawner, and then passing them worked fine, so this is how I got around it.
 
 One of the last parts of the project I did was making the menus, which I haven't had in a game before. I found another YouTube video to help with this, and was surprised by how simple Unity makes it to make menus. Finally, I went online to find graphics and a sound effect for my game, and decided that my project was finished there. 
 
 In future, I will definitely make sure my scale is more suitable for functional purposes, rather than what size something would be in real life, and this would be the first thing I'd change if I was to redo this project. I would also have liked to add more enemies rather than the simple rolling apple I had, and probably more sound effects/music to the game. I am the most happy with the roots in my game, and whilst I think it could have been better, I had probably spent more time than I already should have on creating them - though this has made me realise that I find procedural animation very interesting, aswell as the physics surrounding it and its potential for AI-learning simulations. 

### Credit:

https://www.youtube.com/watch?v=9hTnlp9_wX8&t=534s for tendrils

https://stackoverflow.com/questions/48925622/displaying-score-in-another-scene-on-unity Score carry-over through scenes

https://opengameart.org/content/evil-sun-flower-plant-sprites-for-game-developers Flower Graphic

https://opengameart.org/content/fruits Apple Graphic

https://www.youtube.com/watch?v=zc8ac_qUXQY&list=LL&inde for menus

https://freesound.org/people/deleted_user_2104797/sounds/148979/ fruit Squash sound
