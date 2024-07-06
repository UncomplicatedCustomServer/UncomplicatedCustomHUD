using Exiled.API.Features;
using Exiled.API.Features.Pools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UncomplicatedCustomHUD.API.Interfaces;

namespace UncomplicatedCustomHUD.API.Features
{
    public abstract class DisplayBase<T> : IDisplay<T> where T : IDisplayItem, new()
    {
        public DisplayBase(Player player)
        {
            Player = player;

            items = ListPool<T>.Pool.Get();
            stringBuilder = StringBuilderPool.Pool.Get();
        }

        ~DisplayBase()
        {
            ListPool<T>.Pool.Return(items);
            StringBuilderPool.Pool.Return(stringBuilder);
        }

        public abstract string Name { get; }

        public abstract bool IsEnabled { get; }

        public Player Player { get; }

        public IReadOnlyList<T> Items => items;

        protected readonly List<T> items;

        protected StringBuilder stringBuilder;

        public abstract void Display(T displayItem);

        public virtual void Display()
        {
            stringBuilder.Clear();

            //ToList because we can delete item in Display(T displayItem)
            foreach (var item in items.ToList())
            {
                Display(item);
            }
        }

        public void Display(IDisplayItem displayItem)
        {
            Display((T)displayItem);
        }
    }
}
