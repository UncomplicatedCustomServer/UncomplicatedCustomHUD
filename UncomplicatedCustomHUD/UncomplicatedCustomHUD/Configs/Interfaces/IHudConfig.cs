using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UncomplicatedCustomHUD.Configs.Interfaces
{
    public interface IHudConfig
    {
        bool IsEnabled { get; set; }

        string Content { get; set; }
    }
}
