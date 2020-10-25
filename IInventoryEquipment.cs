using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace JRPG.NET
{
    public interface IInventoryEquipment : IRecognizable
    {

        public Dictionary<String, IItem> ItemSlots { get; set; }

        public int TotalWeight { get; }
        public XmlElement Metadata { get; set; }

    }
}
