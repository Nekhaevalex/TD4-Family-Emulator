namespace TD4_Family_Emulator
{
    public enum opcode
    {
        Add, Mov, In, Out, Swi, Swm, Ld, St, Jnc, Jmp
    }
    public enum reg
    {
        a, b
    }
    public struct regs
    {
        public reg arg1;
        public reg arg2;
    }
    public class Instruction
    {
        opcode opcode;
        byte im;
        public bool usesRegsAsArg1 = false;
        public bool usesRegsAsArg2 = false;
        public regs regs;
        public byte Im { get => im; set => im = value; }
        internal opcode Opcode { get => opcode; set => opcode = value; }
    }
}