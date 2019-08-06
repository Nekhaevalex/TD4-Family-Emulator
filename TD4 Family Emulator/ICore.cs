using System;
using System.Collections.Generic;
using System.Text;

namespace TD4_Family_Emulator
{
    struct registers_state
    {
        byte reg_a;     //A register
        byte reg_b;     //B register
        byte reg_pc;    //Programm counter register
        byte reg_ip;    //Instruction page register
        byte reg_mp;    //Memory page register
        bool c;         //Carry flag register
    }
    interface ICore
    {
        registers_state Registers { get;}

        void ExecuteInstruction(Instruction instruction);
        registers_state GetRegisters();

    }
}
