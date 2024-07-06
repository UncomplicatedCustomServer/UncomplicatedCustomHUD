using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UncomplicatedCustomHUD.API.Interfaces;

namespace UncomplicatedCustomHUD.API.Features.Hud
{
    public class HudDisplayItem : IDisplayItem
    {
        public string Content { get; set; }

        public float Time { get; set; }
    }
}
