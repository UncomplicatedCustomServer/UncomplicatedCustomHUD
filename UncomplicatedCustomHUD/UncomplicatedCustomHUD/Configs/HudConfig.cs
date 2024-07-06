using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UncomplicatedCustomHUD.Configs.Interfaces;

namespace UncomplicatedCustomHUD.Configs
{
    public class HudConfig : IHudConfig
    {
        [Description("Is enabled")]
        public bool IsEnabled { get; set; }

        [Description("Content, all placeholders will be replaced")]
        public string Content { get; set; } =
            "|%server_name%|\n" +
            "|Role: %role%|\n" +
            "|Donate: not_scam_one_hungred_percent.com|";
    }
}
