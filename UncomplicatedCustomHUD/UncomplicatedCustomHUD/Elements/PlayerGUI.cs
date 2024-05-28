#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using CustomPlayerEffects;
using Exiled.API.Enums;
using Exiled.API.Extensions;
using Exiled.API.Features;
using MEC;
using UncomplicatedCustomHUD.Interfaces;

namespace UncomplicatedCustomHUD.Elements
{
    public class PlayerGUI : IPlayerGUI
    {
        public int Id { get; set; } = -1;
        public Player Player { get; set; } = null;
        
        public string Hint { get; set; } = String.Empty;
        public IDictionary<EffectType, int> Effects { get; set; } = new Dictionary<EffectType, int>();

        public CoroutineHandle GUIRoutine { get; set; }

        public PlayerGUI()
        {
            
        }

        public virtual void Start()
        {
            GUIRoutine = Timing.RunCoroutine(GUIDisplayRoutine());
        }

        private IEnumerator<float> GUIDisplayRoutine()
        {
            yield return Timing.WaitForSeconds(1);
            while (Timing.IsRunning(GUIRoutine))
            {
                if (Player.IsAlive)
                {
                    
                } 
            }
        }
        
        // TO FIT: 38 size 32 lines
        // Visible on screen 1-29 (ZERO ISNT VISIBLE)
        
        private void BuildDead()
        {
            string LocalHint;

            LocalHint = $"<align=center><size=32>";
            LocalHint += $"\t\n";
        }

        private void BuildAlive()
        {
            
        }
        
        private void UpdateEffects()
        {
            foreach (StatusEffectBase e in this.Player.ActiveEffects)
            {
                Effects.Add(e.GetEffectType(), (int)e.TimeLeft);
            }
        }

        private void DrawHint()
        {
            
        }
    }
}