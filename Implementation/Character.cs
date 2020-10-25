using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace JRPG.NET.Implementation
{
    public class Character : ICharacter
    {
        public IStat GlobalReputation { get; set; }
        public IStat Force { get; set; }
        public IStat Dexterity { get; set; }
        public IStat Intelligence { get; set; }
        public IStat Wisdom { get; set; }
        public IStat Charisma { get; set; }
        public ISpecialStats Reflex { get; set; }
        public ISpecialStats Vitality { get; set; }
        public ISpecialStats Willingness { get; set; }
        public List<Delegate> DynamicModifiers { get; set; }
        public List<ISpecialAbility> specialAbilities { get; set; }
        public List<ISpell> Spells { get; set; }
        public IInventory Inventory { get; set; }
        public IInventoryEquipment InventoryEquipment { get; set; }
        public XmlElement Metadata { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public float XP { get; set; }
        public IClass Class { get; set; }
        public float Mana { get; set; }
        public float Life { get; set; }
        public UniqueId UniqueId { get; private set; }

        public Character ()
        {
            UniqueId = new UniqueId();
        }
    }
}
