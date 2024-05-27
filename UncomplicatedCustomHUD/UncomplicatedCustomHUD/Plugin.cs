using Exiled.API.Features;
using HarmonyLib;
using System;

namespace UncomplicatedCustomHUD
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance { get; private set; }
        public override string Author => "ImIsaacTbh";
        public override Version RequiredExiledVersion { get; } = new(8, 8, 0);
        public override Version Version { get; } = new(0, 0, 1);
        public string PresenceUrl = "https://uci.fcosma.it/api/v2/uchud/presence";

        public override void OnEnabled()
        {
            Instance = this;
            
            Log.Info("===========================================");
            Log.Info(" Thanks for using UncomplicatedCustomHUD");
            Log.Info("        by ImIsaacTbh");
            Log.Info("===========================================");
            Log.Info(">> Join our discord: https://discord.gg/5StRGu8EJV <<");
            
            //Events.Internal.Player.Register();
            //Events.Internal.Server.Register();
            
            base.OnEnabled();
        }
        
        public override void OnDisabled()
        {
            //Events.Internal.Player.Unregister();
            //Events.Internal.Server.Unregister();

            Instance = null;

            base.OnDisabled();
        }
    }
}