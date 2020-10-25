using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace JRPG.NET
{
    public interface IStat : IRecognizable
    {

        /// <summary>
        /// Generally TV = V + M + TV + TM
        /// </summary>
        public int TotalValue { get; set; }
        
        public int Value { get; set; }
        public int Modifier { get; set; }
        public int TemporaryValue { get; set; }
        public int TemporaryModifier { get; set; }
        public XmlElement Metadata { get; set; }

    }
}
