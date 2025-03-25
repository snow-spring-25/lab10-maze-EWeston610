using labyrinth;

/* Eric Weston 3/25 Lab 10
 *
 * WARNING: Once you've set set this constant and started exploring your maze,
 * do NOT edit the value of YourName. Changing YourName will change which
 * maze you get back, which might invalidate all your hard work!
*/
string YOUR_NAME = "Eric Weston";

/* Change these constants to contain the paths out of your mazes. */
string PATH_OUT_OF_MAZE = "ESENESNWSSEWNWWSESEE";
string PATH_OUT_OF_TWISTY_MAZE = "EESWSENEEWNNSSW";

MazeCell startLocation = MazeUtilities.mazeFor(YOUR_NAME);

/* Set a breakpoint here to explore your maze! */

if (MazeUtilities.isPathToFreedom(startLocation, PATH_OUT_OF_MAZE))
{
Console.WriteLine("Congratulations! You've found a way out of your labyrinth.");
}
else
{
Console.WriteLine("Sorry, but you're still stuck in your labyrinth.");
}


MazeCell twistyStartLocation = MazeUtilities.twistyMazeFor(YOUR_NAME);

/* Set a breakpoint here to explore your twisty maze! */

if (MazeUtilities.isPathToFreedom(twistyStartLocation, PATH_OUT_OF_TWISTY_MAZE))
{
Console.WriteLine("Congratulations! You've found a way out of your twisty labyrinth.");
}
else
{
Console.WriteLine("Sorry, but you're still stuck in your twisty labyrinth.");
}

