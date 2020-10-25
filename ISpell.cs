using System.Xml;

namespace JRPG.NET
{
    public interface ISpell : IRecognizable
    {

        public int TurnBuffer { get; }
        public void ResetTurnBuffer();
        public void SetTurnBuffer(int count);
        public void AddTurnBuffer(int count);
        public void SubtractTurnBuffer(int count);

        public int TurnReload { get; set; }
        public int ManaConsumption { get; set; }

        public XmlElement Metadata { get; set; }
    
    }
}