using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace JRPG.NET
{
    public interface ISpecialStats : IRecognizable
    {

        public int TotalValue { get; }

        public int BaseBonus { get; set; }
        public int CharacterModifier { get; set; }
        public int MagicModifier { get; set; }
        public int DiversModifier { get; set; }
        public int TemporaryModifier { get; set; }
        public XmlElement Metadata { get; set; }

    }
}
