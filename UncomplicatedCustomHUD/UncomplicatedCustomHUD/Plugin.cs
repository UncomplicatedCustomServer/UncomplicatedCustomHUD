using Exiled.API.Features;
using HarmonyLib;
using MEC;
using System;
using System.Collections.Generic;
using UncomplicatedCustomHUD.API.Components;
using UncomplicatedCustomHUD.API.Features.Tooltip;

namespace UncomplicatedCustomHUD
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance { get; private set; }

        public static Config Configs => Instance.Config;

        public override string Author => "ImIsaacTbh & SpGerg";

        public override Version RequiredExiledVersion { get; } = new(8, 9, 6);

        public override Version Version { get; } = new(1, 0, 0);

        public string PresenceUrl = "https://uci.fcosma.it/api/v2/uchud/presence";

        private Harmony _harmony;

        public override void OnEnabled()
        {
            _harmony = new Harmony($"uncomplicated-custom-hud");
            //_harmony.PatchAll();

            Instance = this;

            Events.Internal.Player.Register();
            
            Log.Info("===========================================");
            Log.Info(" Thanks for using UncomplicatedCustomHUD   ");
            Log.Info("        by ImIsaacTbh & SpGerg");
            Log.Info("===========================================");
            Log.Info(">> Join our discord: https://discord.gg/5StRGu8EJV <<");
            
            base.OnEnabled();
        }
        
        public override void OnDisabled()
        {
            Events.Internal.Player.Unregister();

            base.OnDisabled();
        }
    }
}