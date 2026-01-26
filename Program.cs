using DiscordBattler.GameObjects;
using System.Collections.Generic;
using System.Linq;

namespace DiscordBattler;

public class DiscordBattler
{
    public static void Main()
    {
        Combatant adamNeaj = new Combatant(
            "Adam Neaj",
            "An amazing fighter,",
            100,
            100,
            1,
            1,
            0,
            1,
            1
        );

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
        
        playerOne.Move("north");
    }
}