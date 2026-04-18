using Exiled.API.Features;
using System;
using System.Collections.Generic;

namespace GPDebugger.Core.Class
{
    public static class DebugManager
    {
        public static HashSet<string> EnabledHandlerUsers = new();
        public static HashSet<string> EnabledNetworkUsers = new();

        public static HashSet<string> HandlerWhitelist = new(StringComparer.OrdinalIgnoreCase);
        public static HashSet<string> KnownHandlers = new(StringComparer.OrdinalIgnoreCase);
        public static HashSet<string> IgnoredHandlers = new(StringComparer.OrdinalIgnoreCase);
        public static HashSet<string> IgnoredEvents = new(StringComparer.OrdinalIgnoreCase);

        public static HashSet<string> KnownNetworkMethods = new(StringComparer.OrdinalIgnoreCase);
        public static HashSet<string> KnownNetworkMessages = new(StringComparer.OrdinalIgnoreCase);
        public static HashSet<string> IgnoredNetworkMethods = new(StringComparer.OrdinalIgnoreCase);
        public static HashSet<string> IgnoredNetworkMessages = new(StringComparer.OrdinalIgnoreCase);

        public static bool IsEnabled(Player player) => EnabledHandlerUsers.Contains(player.UserId) || EnabledNetworkUsers.Contains(player.UserId);

        public static bool IsHandlerEnabled(string handler)
        {
            if (HandlerWhitelist.Count > 0 && !HandlerWhitelist.Contains(handler))
                return false;

            return !IgnoredHandlers.Contains(handler);
        }
    }
}
