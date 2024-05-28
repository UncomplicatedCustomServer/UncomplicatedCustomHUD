using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using MEC;

namespace UncomplicatedCustomHUD.Interfaces
{
    public interface IPlayerGUI
    {
        public abstract int Id { get; set; }
        public abstract Player Player { get; set; }
        public abstract string Hint { get; set; }
        public abstract IDictionary<EffectType, int> Effects { get; set; }
        public CoroutineHandle GUIRoutine { get; set; }
    }
}