﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UncomplicatedCustomHUD.Configs.Interfaces;

namespace UncomplicatedCustomHUD.Configs
{
    public class TooltipConfig : IHudConfig
    {
        [Description("Is enabled")]
        public bool IsEnabled { get; set; }

        [Description("Max distance to target")]
        public float Distance { get; set; } = 5f;

        [Description("Content, all placeholders will be replaced")]
        public string Content { get; set; } =
            $"|Name: %player_name%|\n" +
            $"|Role: %player_role%|";
    }
}
