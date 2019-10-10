using System;
using System.Collections.Generic;
using System.Text;

namespace TD4_Family_Emulator
{
    public struct registers_state
    {
        public byte reg_a;     //A register
        public byte reg_b;     //B register
        public byte reg_pc;    //Programm counter register
        public byte reg_ip;    //Instruction page register
        public byte reg_mp;    //Memory page register
        public bool c;         //Carry flag register
    }
    interface ICore
    {
        registers_state Registers { get;}

        void ExecuteInstruction(Instruction instruction);
        registers_state GetRegisters();

    }
}
