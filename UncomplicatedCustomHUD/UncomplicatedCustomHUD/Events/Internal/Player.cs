using Exiled.Events.EventArgs.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UncomplicatedCustomHUD.API.Extensions;
using UncomplicatedCustomHUD.API.Features.Hud;
using UncomplicatedCustomHUD.API.Features.Tooltip;
using UncomplicatedCustomHUD.API.Interfaces;
using EventSource = Exiled.Events.Handlers.Player;

namespace UncomplicatedCustomHUD.Events.Internal
{
    internal static class Player
    {
        public static void Register()
        {
            EventSource.Verified += AddComponentOnVerified;
        }

        public static void Unregister()
        {
            EventSource.Verified -= AddComponentOnVerified;
        }

        private static void AddComponentOnVerified(VerifiedEventArgs ev)
        {
            var player = ev.Player;

            player.CreateRenderer();

            player.AddDisplay(new HudDisplay(player));
            player.AddDisplay(new TooltipDisplay(player));
        }
    }
}
