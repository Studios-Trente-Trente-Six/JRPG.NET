using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace JRPG.NET
{
    public interface IInventory : IRecognizable
    {

        public List<IItemStack> ItemStacks { get; set; }

        public int MaxStackSize { get; set; }

        public int GetActualWeight();
        public XmlElement Metadata { get; set; }

    }
}
