using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace JRPG.NET
{
    public interface IGlobalContainer
    {

        /// <summary>
        /// Every Game Object Referenced with its Unique ID. This can include child objetcs
        /// </summary>
        public Dictionary<UniqueId, IRecognizable> GameObjects { get; set; }

    }
}
