using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace GPDebugger
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("The maximum length of a message to show in the console.")]
        public int ConsoleMessageLengthLimit { get; set; } = 100;
        [Description("The color of the console messages.")]
        public string ConsoleMessageColor { get; set; } = "white";

        [Description("List of handlers to allow. If this list has at least one value, only these handlers will be logged. (ex. Player, Server)")]
        public List<string> HandlerWhitelist { get; set; } = new();

        [Description("List of events to ignore from being printed. (ex. Player.MakingNoiseEventArgs)")]
        public List<string> IgnoredEvents { get; set; } = new()
        {
            "Player.MakingNoiseEventArgs",
            "Player.TriggeringTeslaEventArgs",
            "Item.UsingRadioPickupBatteryEventArgs",
            "Item.UsingRadioBatteryEventArgs"
        };
    }
}
