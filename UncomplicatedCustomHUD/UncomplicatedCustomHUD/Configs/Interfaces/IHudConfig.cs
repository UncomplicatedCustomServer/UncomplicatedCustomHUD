using PlayerRoles;
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

        Dictionary<RoleTypeId, RoleTypeId> SameHudRoles { get; }

        Dictionary<RoleTypeId, string> Content { get; set; }
    }
}
