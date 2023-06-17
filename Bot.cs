using System.Text.Json;
using System.IO;
using DSharpPlus;
using DSharpPlus.EventArgs;
using DSharpPlus.SlashCommands;
using JsonConfig;
using System.Reflection;
using self_bot;

namespace self_bot
{
    public class Bot
    {
        //public DiscordClient Client { get; private set; }
        public DiscordClient Client { get; private set; }
        //public SlashCommandsExtension Slash { get; private set; }
        public SlashCommandsExtension Slash { get; private set; }
        
        public async Task RunAsync()
        {
            var jsonString = await File.ReadAllTextAsync("config.json");

            var configJson = JsonSerializer.Deserialize<ConfigJson>(jsonString);


            /*
            var json = string.Empty;
            using(var fs = File.OpenRead("config.json"))
            using(var sr = new StreamReader(fs, new UTF8Encoding(false)))
                json = await sr.ReadToEndAsync().ConfigureAwait(false);

            var ConfigJson = JsonConvert.DeserializeObject<ConfigJson>(json);
            */




            var config = new DiscordConfiguration
            {
                Token = configJson.Token,
                TokenType = TokenType.Bot,
                AutoReconnect = true
            };
            
            Client = new DiscordClient(config);

            Client.Ready += OnClientReady;
            
            var slashConfig = new SlashCommandsConfiguration
            {

            };

            Slash = Client.UseSlashCommands(slashConfig);

            SlashRegistry.RegisterCommands(Slash);

            await Client.ConnectAsync();
            await Task.Delay(-1);

        }

        private Task OnClientReady(DiscordClient sender, ReadyEventArgs e)
        {
            return Task.CompletedTask;
        }

    }
}