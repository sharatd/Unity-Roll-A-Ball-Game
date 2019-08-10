# Unity-Roll-A-Ball
The user gets points by hitting targets. I improved upon the basic Roll-A-Ball game tutorial by including negative points for colliding with walls. Also, random targets regenerate after the user hits 
a wall and there are multiple UIs for the user's points and time elapsed as well as a final message for when the user wins. 
As I became familiar with Unity and the C# language, I was able to apply some of the object-oriented programming I learned from Java
while also learning new skills. For instance, I figured out how to make a trigger for each collectible so that a certain target 
would be deactivated when hit by the player. I look forward to further improving this game by including different types of targets that count
for different amounts of points. 

During this project, I had to create a game area with walls and targets that could disappear after the player hits them. In order to make 
the collectibles disappear, I had to create a trigger for each cube. I used the idea of prefabs in the Unity interface which lets the game
developer make changes to a group of game objects and, in this case, a group of targets. 

Objectives:
1. Use arrow keys to move player around the game area
2. Win by getting 12 points (each target is 1 point)
3. Avoid hitting the walls which decrease the user's score
4. Win the game in the least amount of time possible

Modifications on Unity Roll-A-Ball Tutorial:
1. User's score decreases by 1 every time the player hits a wall
2. There are UIs for the score and time as well as a final message when the user wins
3. Random cubes regenerate when the player hits a wall so that the user can still get 12 points

Potential Improvements:
1. Create different types of targets with different score values
2. Make obstacles throughout the course that the user has to avoid
3. Add background images
