
using System.Collections.Generic;
using System.Xml;

namespace JRPG.NET
{
    public interface ICharacter : IRecognizable
    {

        #region Stats
        public IStat GlobalReputation { get; set; }

        public IStat Force { get; set; }
        public IStat Dexterity { get; set; }
        public IStat Intelligence { get; set; }
        public IStat Wisdom { get; set; }
        public IStat Charisma { get; set; }

        public ISpecialStats Reflex { get; set; }
        public ISpecialStats Vitality { get; set; }
        public ISpecialStats Willingness { get; set; }

        /// <summary>
        /// These are delegate functions that can be triggered dynamically to change stats during gameplay
        /// </summary>
        public List<System.Delegate> DynamicModifiers { get; set; }
        #endregion

        public List<ISpecialAbility> specialAbilities { get; set; }

        public List<ISpell> Spells { get; set; }
        public IInventory Inventory { get; set; }
        public IInventoryEquipment InventoryEquipment { get; set; }
        public XmlElement Metadata { get; set; }

        #region GamePlayData
        public string Name { get; set; }
        public int Level { get; set; }
        public float XP { get; set; }
        public IClass Class { get; set; }
        public float Mana { get; set; }
        public float Life { get; set; }
        #endregion

    }
}
