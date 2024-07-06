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

            target.GetDisplay<HudDisplay>().ShowHint(displayItem.Content, Plugin.Configs.RefreshRate);
        }
    }
}
