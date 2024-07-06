using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using UncomplicatedCustomHUD.Configs;
using UnityEngine;

namespace UncomplicatedCustomHUD
{
    public class Config : IConfig
    {
        [Description("Is enabled or not")]
        public bool IsEnabled { get; set; } = true;

        [Description("Do enable the developer (debug) mode?")]
        public bool Debug { get; set; } = true;

        [Description("Refresh rate")]
        public float RefreshRate { get; set; } = 1f;

        [Description("Hud config")]
        public HudConfig HudConfig { get; set; } = new();

        [Description("Tooltip config")]
        public TooltipConfig TooltipConfig { get; set; } = new();
    }
}