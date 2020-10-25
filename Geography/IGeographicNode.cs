using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace JRPG.NET.Geography
{
    public interface IGeographicNode : IRecognizable
    {

        public XmlElement Metadata { get; set; }
        public List<UniqueId> Connections { get; set; }

        public List<IGeographicNode> GeographicNodesChildren { get; set; }

    }
}
