namespace DiscordBattler.GameEngine;

public class Commands(Dictionary<string, Action> commandsToAdd)
{
        // This maybe needs to be a 
        private Dictionary<string, Action> ValidCommands = new Dictionary<string, Action>();

        public  bool ValidateCommand(string userCmd)
        {
                string[] cmdAndArgs = userCmd.Split(" ");
                
                if (!ValidCommands.ContainsKey(userCmd))
                {
                     Console.Error.WriteLine($"I do not know how to '{userCmd}'.");
                     return false;
                }

                return true;
        }
}