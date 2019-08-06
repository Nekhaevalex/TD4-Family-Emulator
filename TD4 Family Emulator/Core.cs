using System;
using System.Collections.Generic;
using System.Text;

namespace TD4_Family_Emulator
{
    class Core : ICore
    {
        private static registers_state registers_State;
        public registers_state Registers { get => registers_State; }

        public registers_state GetRegisters()
        {
            return Registers;
        }
    }
}
