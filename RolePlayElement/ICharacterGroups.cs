using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace JRPG.NET.RolePlayElement
{
    public interface ICharacterGroups : IRecognizable
    {
        public List<UniqueId> members { get; set; }

        /// <summary>
        /// Adds a member
        /// </summary>
        /// <param name="uniqueId">A unique ID Referencing a character</param>
        public void AddMember(UniqueId uniqueId);
        /// <summary>
        /// Adds a member
        /// </summary>
        /// <param name="character">A character</param>
        public void AddMember(ICharacter character);
    }
}
