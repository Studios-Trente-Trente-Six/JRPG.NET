using System.Xml;

namespace JRPG.NET
{
    public interface IItemStack : IRecognizable
    {

        public int Count { get; set; }
        public IItem Item { get; set; }

        public void Add (int count);
        public void Subtract (int count);
        public void Set (int count);
        public XmlElement Metadata { get; set; }

    }
}