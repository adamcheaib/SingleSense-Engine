using DiscordBattler.GameEngine;
using DiscordBattler.GameObjects;

namespace DiscordBattler;

public class DiscordBattler
{
    public static void Main()
    {
        Player playerOne = new Player(
            "Elia",
            "An amazing person.",
            1337,
            100,
            1,
            1,
            0,
            1, 1
        );
     
        Map.PrintMap(playerOne);
        playerOne.Move("south");
        Map.PrintMap(playerOne);
        playerOne.Move("south");
        Map.PrintMap(playerOne);
        playerOne.Move("east");
        Map.PrintMap(playerOne);
    }
}