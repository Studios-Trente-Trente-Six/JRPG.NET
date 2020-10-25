using System;
using System.Collections.Generic;
using System.Xml;

namespace JRPG.NET
{
    public interface IItem : IRecognizable
    {

        public int MaxCountByStack { get; set; }
        public int RarityCoefficiant { get; set; }
        public int Level { get; set; }
        public List<EItemType> ItemTypes { get; set; }
        public List<EItemClass> ItemClasses { get; set; }

        public int Weight { get; set; }

        public XmlElement Metadata { get; set; }

    }
}