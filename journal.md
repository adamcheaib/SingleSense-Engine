I currently left off in the Player class, specifically the Move-method.

I am handling the movement via the Movement-class. The algorithm is as follows:
1. The player wants to move by inputting a character or a string e.g. "north" or "n".
2. The Movement-engine controls that the input is a valid direction
3. The Map engine controls that the tile that the player wants to move to is a valid tile.

However, this should be re-designed. The thing is whenever the player is at a coordinate, the map OR movement engine
should automatically scan for which directions the player can go. In other words, this should be automated. Below is a scenario:

**The player starts at coordinates 1,1. The (future) scene-class prints out "You are at [scene name]".

The scene then prints out its [description]. The Map engine scans for available routes and adds what direction the player can go.
For example, "I can walk north, south or east." **