using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace JRPG.NET
{
    interface ICompetence : IRecognizable
    {

        /// <summary>
        /// Generally TV = CM + RM + DM
        /// </summary>
        public int TotalValue { get; }
        
        public int CharacteristicModulator { get; set; }
        public int RankModulator { get; set; }
        public int DiverseModulator { get; set; }

        public XmlElement Metadata { get; set; }

    }
}
