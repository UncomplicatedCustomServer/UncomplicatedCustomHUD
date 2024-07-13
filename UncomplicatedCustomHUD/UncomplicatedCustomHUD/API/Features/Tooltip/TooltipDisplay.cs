using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UncomplicatedCustomHUD.API.Extensions;
using UncomplicatedCustomHUD.API.Features.Hud;
using UncomplicatedCustomHUD.API.Interfaces;
using static UnityEngine.GraphicsBuffer;

namespace UncomplicatedCustomHUD.API.Features.Tooltip
{
    public class TooltipDisplay : DisplayBase<TooltipDisplayItem>
    {
        public TooltipDisplay(Player player) : base(player)
        {
        }

        public override string Name => "Tooltip";

        public override bool IsEnabled => Plugin.Configs.TooltipConfig.IsEnabled;

        public override void Display()
        {
            if (!Player.TryGetPlayerOpposite(out var target))
            {
                return;
            }

            foreach (var item in items)
            {
                Display(target, item);
            }
        }

        public override void Display(TooltipDisplayItem displayItem) => Display(null, displayItem);

        public void Display(Player target, TooltipDisplayItem displayItem)
        {
            if (target is null)
            {
                return;
            }

            target.GetDisplay<HudDisplay>().ShowHint(SetPlaceholders(target, displayItem.Content), Plugin.Configs.RefreshRate);
        }

        //will be better later.
        private string SetPlaceholders(Player player, string content)
        {
            return content.Replace("{tooltip_player_name}", player.Nickname).Replace("{tooltip_player_user_id}", content)
                .Replace("{tooltip_player_health}", player.Health.ToString()).Replace("{tooltip_player_max_health}", player.MaxHealth.ToString())
                .Replace("{tooltip_player_humeshield}", player.HumeShield.ToString()).Replace("{tooltip_player_ahp}", player.ArtificialHealth.ToString())
                .Replace("{tooltip_player_role_name}", player.Role.Type.ToString());
        }
    }
}
