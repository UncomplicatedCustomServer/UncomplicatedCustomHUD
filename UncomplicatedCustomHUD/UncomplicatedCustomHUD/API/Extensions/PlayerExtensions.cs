using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UncomplicatedCustomHUD.API.Components;
using UncomplicatedCustomHUD.API.Interfaces;
using UnityEngine;

namespace UncomplicatedCustomHUD.API.Extensions
{
    public static class PlayerExtensions
    {
        public static void AddDisplay(this Player player, IDisplay<IDisplayItem> display) => player.GetRenderer().AddDisplay(display);

        public static T GetDisplay<T>(this Player player) where T : IDisplay<IDisplayItem> => player.GetRenderer().GetDisplay<T>();

        public static Components.Renderer GetRenderer(this Player player) => player.GameObject.GetComponent<Components.Renderer>();

        public static void CreateRenderer(this Player player) => player.GameObject.AddComponent<Components.Renderer>();

        public static bool TryGetPlayerOpposite(this Player player, out Player target)
        {
            target = player.GetPlayerOpposite();

            return target is not null;
        }

        public static Player GetPlayerOpposite(this Player player)
        {
            if (!Physics.Raycast(player.CameraTransform.position, player.CameraTransform.forward, out var hit, Plugin.Configs.TooltipConfig.Distance))
            {
                return null;
            }

            return Player.Get(hit.collider);
        }
    }
}
