using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UncomplicatedCustomHUD.API.Interfaces
{
    public interface IDisplayItem
    {
        /// <summary>
        /// Item content
        /// </summary>
        string Content { get; }
    }
}
