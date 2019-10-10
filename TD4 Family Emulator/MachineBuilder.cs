using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace TD4_Family_Emulator
{
    class MachineBuilder
    {
        public MachineBuilder(string config)
        {
            XmlTextReader reader = new XmlTextReader(config);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        break;
                }
            }
        }
    }
}
