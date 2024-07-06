using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UncomplicatedCustomHUD.API.Interfaces;

namespace UncomplicatedCustomHUD.API.Features.Tooltip
{
    public class TooltipDisplayItem : IDisplayItem
    {
        public string Content { get; set; }
    }
}
