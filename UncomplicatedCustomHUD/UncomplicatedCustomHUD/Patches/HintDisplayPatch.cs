using Exiled.API.Features;
using HarmonyLib;
using Hints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UncomplicatedCustomHUD.API.Extensions;
using UncomplicatedCustomHUD.API.Features.Hud;

namespace UncomplicatedCustomHUD.Patches
{
    [HarmonyPatch(typeof(HintDisplay), nameof(HintDisplay.Show))]
    public static class HintDisplayPatch
    {
        public static bool Prefix(HintDisplay __instance, Exiled.API.Features.Hint hint)
        {
            var renderer = Player.Get(__instance.gameObject).GetRenderer();
            renderer.GetDisplay<HudDisplay>().ShowHint(hint.Content, hint.Duration);
            renderer.Render();

            return false;
        }
    }
}
