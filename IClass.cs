using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace JRPG.NET
{
    public interface IClass : IRecognizable
    {

        public int Level { get; set; }
        public float XP { get; set; }

    }
}
