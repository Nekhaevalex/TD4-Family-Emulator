using System.IO;

namespace TD4_Family_Emulator
{
    class ProgramLoader
    {
        public ProgramLoader(string filename)
        {
            byte[] fileBytes = File.ReadAllBytes(filename);
            Instruction[] instructions = new Instruction[fileBytes.Length];
            for (int i = 0; i < fileBytes.Length; i += 2)
            {
                switch (fileBytes[i])
                {
                    case 0b0000:
                        instructions[i].Opcode = opcode.Add;
                        instructions[i].regs.arg1 = reg.a;
                        instructions[i].usesRegsAsArg1 = false;
                        instructions[i].Im = fileBytes[i + 1];
                        break;
                    case 0b0001:
                        instructions[i].Opcode = opcode.Mov;
                        instructions[i].regs.arg1 = reg.a;
                        instructions[i].regs.arg2 = reg.b;
                        instructions[i].usesRegsAsArg1 = true;
                        instructions[i].usesRegsAsArg2 = true;
                        instructions[i].Im = fileBytes[i + 1];
                        break;
                    case 0b0010:
                        instructions[i].Opcode = opcode.In;
                        instructions[i].regs.arg1 = reg.a;
                        instructions[i].usesRegsAsArg1 = true;
                        instructions[i].usesRegsAsArg2 = false;
                        instructions[i].Im = fileBytes[i + 1];
                        break;
                    case 0b0011:
                        instructions[i].Opcode = opcode.Mov;
                        instructions[i].regs.arg1 = reg.a;
                        instructions[i].regs.arg2 = reg.b;
                        instructions[i].usesRegsAsArg1 = true;
                        instructions[i].usesRegsAsArg2 = false;
                        break;
                }
            }
        }
    }
}
