using System.Xml;

namespace JRPG.NET
{
    public interface ISpecialAbility : IRecognizable
    {

        public XmlElement Metadata { get; set; }

    }
}