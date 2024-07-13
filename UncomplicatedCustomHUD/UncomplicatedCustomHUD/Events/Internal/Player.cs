using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using MEC;
using PlayerRoles;
using UncomplicatedCustomHUD.API.Extensions;
using UncomplicatedCustomHUD.API.Features.Hud;
using UncomplicatedCustomHUD.API.Features.Tooltip;
using EventSource = Exiled.Events.Handlers.Player;

namespace UncomplicatedCustomHUD.Events.Internal
{
    internal static class Player
    {
        public static void Register()
        {
            EventSource.Verified += AddComponentOnVerified;
            EventSource.ChangingRole += UpdateHudOnChangingRole;
        }

        public static void Unregister()
        {
            EventSource.Verified -= AddComponentOnVerified;
            EventSource.ChangingRole -= UpdateHudOnChangingRole;
        }

        private static void UpdateHudOnChangingRole(ChangingRoleEventArgs ev)
        {
            var player = ev.Player;

            if (player.Role.Type is RoleTypeId.None && !Plugin.Configs.HudConfig.Content.ContainsKey(player.Role.Type))
            {
                Timing.CallDelayed(Timing.WaitForOneFrame, ev.Player.UpdateHud);

                return;
            }

            ev.Player.UpdateHud();
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
