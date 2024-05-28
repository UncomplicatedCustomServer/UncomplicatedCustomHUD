using Exiled.Events.EventArgs.Player;

namespace UncomplicatedCustomHUD.Events.Internal
{
    internal static class Player
    {
        public static void Register()
        {
            Exiled.Events.Handlers.Player.Joined += OnPlayerJoined;
            Exiled.Events.Handlers.Player.Left += OnPlayerLeft;

            Exiled.Events.Handlers.Player.Spawning += OnPlayerSpawn;
        }

        public static void Unregister()
        {
            Exiled.Events.Handlers.Player.Joined -= OnPlayerJoined;
            Exiled.Events.Handlers.Player.Left -= OnPlayerLeft;

            Exiled.Events.Handlers.Player.Spawning -= OnPlayerSpawn;
        }

        public static void OnPlayerJoined(JoinedEventArgs ev)
        {
            
        }

        public static void OnPlayerLeft(LeftEventArgs ev)
        {
            
        }

        public static void OnPlayerSpawn(SpawningEventArgs ev)
        {
            
        }
    }
}