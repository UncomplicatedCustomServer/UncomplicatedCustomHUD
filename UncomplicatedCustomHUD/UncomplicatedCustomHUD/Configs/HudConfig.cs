using PlayerRoles;
using System.Collections.Generic;
using System.ComponentModel;
using UncomplicatedCustomHUD.Configs.Interfaces;

namespace UncomplicatedCustomHUD.Configs
{
    public class HudConfig : IHudConfig
    {
        [Description("Is enabled")]
        public bool IsEnabled { get; set; }

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
            { RoleTypeId.Spectator, "Next spawn: {round_spawn_wave_time}" },
            { RoleTypeId.ClassD, "health: {player_health}\nrole: {ucr_role_name}" },
            { RoleTypeId.Scp3114, "health: {player_health}\nrole: {ucr_role_name}\nhumeshield: {player_humeshield}" }
        };
    }
}
