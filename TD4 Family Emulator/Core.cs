namespace TD4_Family_Emulator
{
    class Core : ICore
    {
        private static registers_state registers_State;
        public registers_state Registers { get => registers_State; }

        public void ExecuteInstruction(Instruction instruction)
        {
            opcode opcode = instruction.Opcode;
            byte im = instruction.Im;
            switch (opcode)
            {
                case opcode.Add:
                    switch (instruction.regs.arg1)
                    {
                        case reg.a:
                            registers_State.reg_a += im;
                            break;
                        case reg.b:
                            registers_State.reg_b += im;
                            break;
                    }
                    break;
                case opcode.Mov:
                    switch (instruction.regs.arg1)
                    {
                        case reg.a:
                            if (instruction.usesRegsAsArg)
                            {
                                if (instruction.regs.arg2 == reg.b)
                                {
                                    registers_State.reg_a = registers_State.reg_b;
                                }
                                registers_State.reg_a += im;
                            }
                            else
                            {
                                registers_State.reg_a = im;
                            }
                            break;
                        case reg.b:
                            if (instruction.usesRegsAsArg)
                            {
                                if (instruction.regs.arg2 == reg.a)
                                {
                                    registers_State.reg_a = registers_State.reg_b;
                                }
                                registers_State.reg_b += im;
                            }
                            else
                            {
                                registers_State.reg_b = im;
                            }
                            break;
                    }
                    break;
                case opcode.In:
                    switch (instruction.regs.arg1)
                    {
                        case reg.a:
                            //registers_State.reg_a;
                            break;
                        case reg.b:
                            //registers_State.reg_b;
                            break;
                    }
                    break;
                case opcode.Out:
                    if (instruction.usesRegsAsArg)
                    {
                        switch (instruction.regs.arg1)
                        {
                            case reg.a:
                                //registers_State.reg_a
                                break;
                            case reg.b:
                                //registers_State.reg_b
                                break;
                        }
                    }
                    else
                    {
                        //out im
                    }
                    break;
                case opcode.Swi:
                    registers_State.reg_ip = instruction.Im;
                    break;
                case opcode.Swm:
                    registers_State.reg_mp = instruction.Im;
                    break;
                case opcode.Ld:
                    //Load from instruction.Im;
                    break;
                case opcode.St:
                    //Store into instruction.Im;
                    break;
                case opcode.Jnc:
                    if (!registers_State.c)
                    {
                        registers_State.reg_pc = instruction.Im;
                    }
                    break;
                case opcode.Jmp:
                    registers_State.reg_pc = instruction.Im;
                    break;
            }
        }

        public registers_state GetRegisters()
        {
            return Registers;
        }
    }
}