using Exiled.API.Features;
using Placeholders.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UncomplicatedCustomHUD.API.Interfaces;
using UnityEngine;

namespace UncomplicatedCustomHUD.API.Features.Hud
{
    public class HudDisplay : DisplayBase<HudDisplayItem>
    {
        public HudDisplay(Player player) : base(player)
        {
        }

        public override string Name => "Hud";

        public override bool IsEnabled => Plugin.Configs.HudConfig.IsEnabled;

        public void ShowHint(string content, float duration = 3f)
        {
            items.Add(new HudDisplayItem()
            {
                Content = content,
                Time = duration < 0 ? duration : Time.time + duration
            });
        }

        public override void Display()
        {
            base.Display();

            Player.ShowHint(stringBuilder.ToString(), Plugin.Configs.RefreshRate + 0.1f);
        }

        public override void Display(HudDisplayItem hudDisplay)
        {
            if (Time.time > hudDisplay.Time && hudDisplay.Time > 0)
            {
                items.Remove(hudDisplay);
                return;
            }

            stringBuilder.AppendLine(PlaceholdersAPI.SetPlaceholders(Player.UserId, hudDisplay.Content));
        }
    }
}
