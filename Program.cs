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

        Combatant demon = new Combatant(
            "Demon",
            "A scary demon",
            100,
            100,
            1,
            1,
            0,
            1,
            2
        );

        BattleSystem testBattle = new BattleSystem();
        testBattle.SetFighters(playerOne, demon);
    }
}