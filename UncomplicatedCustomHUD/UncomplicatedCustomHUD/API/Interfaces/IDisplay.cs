using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UncomplicatedCustomHUD.API.Interfaces
{
    public interface IDisplay<out T> where T : IDisplayItem
    {
        /// <summary>
        /// Display name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Items to render
        /// </summary>
        IReadOnlyList<T> Items { get; }

        /// <summary>
        /// Is enabled
        /// </summary>
        bool IsEnabled { get; }

        /// <summary>
        /// Display item
        /// </summary>
        /// <param name="displayItem"></param>
        void Display(IDisplayItem displayItem);

        /// <summary>
        /// Displayt all items
        /// </summary>
        void Display();
    }
}
