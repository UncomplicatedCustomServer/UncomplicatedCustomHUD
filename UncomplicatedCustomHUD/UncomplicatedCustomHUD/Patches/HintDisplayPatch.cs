﻿using Exiled.API.Features;
using HarmonyLib;
using Hints;
using System.Linq;
using UncomplicatedCustomHUD.API.Extensions;
using UncomplicatedCustomHUD.API.Features.Hud;

namespace UncomplicatedCustomHUD.Patches
{
    [HarmonyPatch(typeof(HintDisplay), nameof(HintDisplay.Show))]
    public static class HintDisplayPatch
    {
        public static bool Prefix(HintDisplay __instance, Hints.Hint hint)
        {
            return true;
        }
    }
}
