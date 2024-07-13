using Exiled.API.Features;
using Exiled.API.Features.Pools;
using MEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UncomplicatedCustomHUD.API.Interfaces;
using UnityEngine;

namespace UncomplicatedCustomHUD.API.Components
{
    public class Renderer : MonoBehaviour
    {
        public static IReadOnlyDictionary<Player, Renderer> Renderers => _renderers;

        private static Dictionary<Player, Renderer> _renderers = new();

        public IReadOnlyList<IDisplay<IDisplayItem>> Displays => _displays;

        public Player Owner { get; private set; }

        public bool IsWasRenderedNow { get; private set; }

        private List<IDisplay<IDisplayItem>> _displays;

        private CoroutineHandle _coroutineHandle;

        public void AddDisplay(IDisplay<IDisplayItem> display)
        {
            if (display is null)
            {
                throw new ArgumentNullException("Display is null");
            }

            _displays.Add(display);

            Log.Debug($"Display {display.Name} was added to {Owner.UserId}");
        }

        public T GetDisplay<T>() where T : IDisplay<IDisplayItem>
        {
            return (T)_displays.FirstOrDefault(display => display is T);
        }

        public void Awake()
        {
            Owner = Player.Get(gameObject);
            _renderers.Add(Owner, this);

            _displays = ListPool<IDisplay<IDisplayItem>>.Pool.Get();

            _coroutineHandle = Timing.RunCoroutine(RenderUpdateCoroutine());

            Log.Debug($"Renderer was added to {Owner.UserId}");
        }

        public void OnDestroy()
        {
            Timing.KillCoroutines(_coroutineHandle);

            _renderers.Remove(Owner);

            ListPool<IDisplay<IDisplayItem>>.Pool.Return( _displays);

            Log.Debug($"Renderer was removed from {Owner.UserId}");
        }

        public void Render()
        {
            IsWasRenderedNow = true;

            foreach (var display in _displays)
            {
                if (!display.IsEnabled)
                {
                    continue;
                }

                display.Display();
            }

            Timing.CallDelayed(Timing.WaitForOneFrame, () =>
            {
                IsWasRenderedNow = false;
            });
        }

        private IEnumerator<float> RenderUpdateCoroutine()
        {
            while (Owner.IsConnected)
            {
                try
                {
                    Render();
                }
                catch (Exception e)
                {
                    Log.Debug(e);
                }

                yield return Timing.WaitForSeconds(Plugin.Configs.RefreshRate);
            }
        }
    }
}
