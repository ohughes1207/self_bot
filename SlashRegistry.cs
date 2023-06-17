using DSharpPlus.SlashCommands;
using self_bot.commands;

namespace self_bot
{
    internal static class SlashRegistry
    {
        //Register commands by adding the class that the commands belong to (all commands within a class will be added if multiple exist)
        internal static void RegisterCommands(SlashCommandsExtension slash)
        {
            slash.RegisterCommands<Test_command>();
            slash.RegisterCommands<Test_command2>();
        }
    }
}