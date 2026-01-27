using DiscordBattler.GameObjects;
using System.Collections.Generic;
using System.Linq;

namespace DiscordBattler;

public class DiscordBattler
{
    public static void Main()
    {
        Player playerOne = new Player(
            "Adam",
            "An amazing person.",
            100,
            100,
            1,
            1,
            0,
            1, 1
        );
     
        playerOne.Move("south");
        playerOne.Move("south");
        playerOne.Move("south");
        playerOne.Move("south");
        playerOne.Move("east");
        playerOne.Move("west");
    }
}