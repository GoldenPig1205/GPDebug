using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPDebug
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("The amount of messages to show in the console.")]
        public int ConsoleMessageSize { get; set; } = 25;
        [Description("The maximum length of a message to show in the console.")]
        public int ConsoleMessageLengthLimit { get; set; } = 100;
    }
}
