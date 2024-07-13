using PlayerRoles;
using System.Collections.Generic;
using System.ComponentModel;
using UncomplicatedCustomHUD.Configs.Interfaces;

namespace UncomplicatedCustomHUD.Configs
{
    public class TooltipConfig : IHudConfig
    {
        [Description("Is enabled")]
        public bool IsEnabled { get; set; }

        [Description("Max distance to target")]
        public float Distance { get; set; }

        public Dictionary<RoleTypeId, RoleTypeId> SameHudRoles { get; set; } = new()
        {
            { RoleTypeId.ChaosRifleman, RoleTypeId.ClassD },
            { RoleTypeId.ChaosConscript, RoleTypeId.ClassD },
            { RoleTypeId.ChaosMarauder, RoleTypeId.ClassD },
            { RoleTypeId.ChaosRepressor, RoleTypeId.ClassD },
            { RoleTypeId.NtfCaptain, RoleTypeId.ClassD },
            { RoleTypeId.NtfSergeant, RoleTypeId.ClassD },
            { RoleTypeId.NtfSpecialist, RoleTypeId.ClassD },
            { RoleTypeId.NtfPrivate, RoleTypeId.ClassD },
            { RoleTypeId.FacilityGuard, RoleTypeId.ClassD },
            { RoleTypeId.Scientist, RoleTypeId.ClassD },
            { RoleTypeId.Scp049, RoleTypeId.Scp3114 },
            { RoleTypeId.Scp173, RoleTypeId.Scp3114 },
            { RoleTypeId.Scp079, RoleTypeId.Scp3114 },
            { RoleTypeId.Scp106, RoleTypeId.Scp3114 },
            { RoleTypeId.Scp0492, RoleTypeId.Scp3114 },
            { RoleTypeId.Scp096, RoleTypeId.Scp3114 }
        };

        public Dictionary<RoleTypeId, string> Content { get; set; } = new()
        {
            { RoleTypeId.Spectator, "???" },
            { RoleTypeId.ClassD, "Name: {tooltip_player_name}\nRole: {tooltip_player_role_name}" },
            { RoleTypeId.Scp3114, "Name: {tooltip_player_name}\nRole: {tooltip_player_role_name}\nhealth: {tooltip_player_health}" }
        };
    }
}
