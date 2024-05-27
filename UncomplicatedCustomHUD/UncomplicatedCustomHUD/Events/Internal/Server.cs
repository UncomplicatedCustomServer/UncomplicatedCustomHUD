namespace UncomplicatedCustomHUD.Events.Internal
{
    internal static class Server
    {
        public static void Register()
        {
            Exiled.Events.Handlers.Server.RestartingRound += OnRestartingRound;
        }

        public static void Unregister()
        {
            Exiled.Events.Handlers.Server.RestartingRound -= OnRestartingRound;
        }

        private static void OnRestartingRound()
        {
            
        }
    }
}