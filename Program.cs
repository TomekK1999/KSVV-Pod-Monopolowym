Console.Clear();
/*
For the future, this game is going to be shit anyway, I just want to learn something useful
In this moment the screen should be empty, just after the clearance of the screen
*/
Console.WriteLine("language menu");
ConsoleGraphics.languageMenu();

/*
In this moment, the player should be able to choose the suitable language,
it means that the dictionary has to be introduced and the choice here 
determains every text in a game later
*/

Console.ReadKey(true);
Console.Clear();

Console.WriteLine("Welcome in polish");
ConsoleGraphics.welcomePL();

/*
Since the game is made based on the example of the society from southern Polish village,
I decided to use Polish as a development phase interface language
*/

Console.ReadKey(true);
Console.Clear();

Console.WriteLine("Game menu in polish");
ConsoleGraphics.menuPL();

/*
This is a moment where the first breakable infinite loop is introduced to keep the game going
and some kind of menu to move around the program
*/

Console.ReadKey(true);
Console.Clear();

Console.WriteLine("map in polish");
ConsoleGraphics.DrawMap();

/*
Here is the very game, either as newgame or a saved one 
*/

Console.ReadKey(true);
Console.Clear();   