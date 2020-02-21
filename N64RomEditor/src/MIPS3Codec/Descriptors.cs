﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N64RomEditor.src.MIPS3Codec
{
    class InstructionDescriptors
    {
        public static readonly Dictionary<string, string> Descriptors = new Dictionary<string, string>()
        {
            {"NOP", "No Operation" },
            {"LB", "Load Byte"},
            {"LBU", "Load Byte Unsigned"},
            {"LD", "Load Double"},
            {"LDL", "Load Double Left"},
            {"LDR", "Load Double Right"},
            {"LH", "Load Half"},
            {"LHU", "Load Half Unsigned"},
            {"LL", "Load Linked Word"},
            {"LLD", "Load Linked Double"},
            {"LW", "Load Word"},
            {"LWL", "Load Word Left"},
            {"LWR", "Load Word Right"},
            {"LWU", "Load Word Unsigned"},
            {"SB", "Store Byte"},
            {"SC", "Store Conditional Word"},
            {"SCD", "Store Conditional Double"},
            {"SD", "Store Double"},
            {"SDL", "Store Double Left"},
            {"SDR", "Store Double Right"},
            {"SH", "Store Half"},
            {"SW", "Store Word"},
            {"SWL", "Store Word Left"},
            {"SWR", "Store Word Right"},
            {"SYNC", "Synchronize Shared Memory"},
            {"ADD", "Add Word"},
            {"ADDI", "Add Immediate Word"},
            {"ADDIU", "Add Immediate Unsigned Word"},
            {"ADDU", "Add Unsigned Word"},
            {"AND", "Bitwise AND Word"},
            {"ANDI", "Bitwise AND Immediate"},
            {"DADD", "Double Add"},
            {"DADDI", "Double Add Immediate"},
            {"DADDIU", "Double Add Immediate Unsigned"},
            {"DADDU", "Double Add Unsigned"},
            {"DDIV", "Double Divide"},
            {"DDIVU", "Double Divide Unsigned"},
            {"DIV", "Divide Word"},
            {"DIVU", "Divide Word Unsigned"},
            {"DMULT", "Multiply Double"},
            {"DMULTU", "Multiply Double Unsigned"},
            {"DSLL", "Double Shift Left Logical"},
            {"DSLL32", "Double Shift Left Logical (shift_amount+=32)"},
            {"DSLLV", "Double Shift Left Logical Variable"},
            {"DSRA", "Double Shift Right Arithmetic"},
            {"DSRA32", "Double Shift right Arithmetic (shift_amount+=32)"},
            {"DSRAV", "Double Shift Right Arithmetic Variable"},
            {"DSRL", "Double Shift Right Logical"},
            {"DSRL32", "Double Shift Right Logical (shift_amount+=32)"},
            {"DSRLV", "Double Shift Right Logical Variable"},
            {"DSUB", "Double Subtract"},
            {"DSUBU", "Double Subtract Unsigned"},
            {"LUI", "Load Upper Immediate"},
            {"MFHI", "Move From HI Register"},
            {"MFLO", "Move From LO Register"},
            {"MTHI", "Move To HI Register"},
            {"MTLO", "Move To LO Register"},
            {"MULT", "Multiply Word"},
            {"MULTU", "Multiply Word Unsigned"},
            {"NOR", "Bitwise NOR Word"},
            {"OR", "Bitwise OR Word"},
            {"ORI", "Bitwise OR Immediate Word"},
            {"SLL", "Word Shift Left Logical"},
            {"SLLV", "Word Shift Left Logical Variable"},
            {"SLT", "Set On Less Than"},
            {"SLTI", "Set On Less Than Immediate"},
            {"SLTIU", "Set On Less Than Immediate Unsigned"},
            {"SLTU", "Set On Less Than Unsigned"},
            {"SRA", "Word Shift Right Arithmetic"},
            {"SRAV", "Word Shift Right Arithmetic Variable"},
            {"SRL", "Word Shift Right Logical"},
            {"SRLV", "Word Shift Right Logical Variable"},
            {"SUB", "Subtract Word"},
            {"SUBU", "Subtract Word Unsigned"},
            {"XOR", "Bitwise XOR Word"},
            {"XORI", "Bitwise XOR Word Immediate"},
            {"BEQ", "Branch On Equal"},
            {"BEQL", "Branch On Equal Likely"},
            {"BGEZ", "Branch On Greater Or Equal To Zero"},
            {"BGEZAL", "Branch On Greater Or Equal To Zero And Link"},
            {"BGEZALL", "Branch On Greater Or Equal To Zero And Link Likely"},
            {"BGEZL", "Branch On Greater Or Equal To Zero Likely"},
            {"BGTZ", "Branch On Greater Than Zero"},
            {"BGTZL", "Branch On Greater Than Zero Likely"},
            {"BLEZ", "Branch On Lesser Or Equal To Zero"},
            {"BLEZL", "Branch On Lesser Or Equal To Zero Likely"},
            {"BLTZ", "Branch On Less Than Zero"},
            {"BLTZAL", "Branch On Less Than Zero And Link"},
            {"BLTZALL", "Branch On Less Than Zero And Link Likely"},
            {"BLTZL", "Branch On Less Than Zero Likely"},
            {"BNEL", "Branch On Not Equal Likely"},
            {"BNE", "Branch On Not Equal"},
            {"J", "Jump"},
            {"JAL", "Jump And Link"},
            {"JALR", "Jump And Link Register"},
            {"JR", "Jump Register"},
            {"BREAK", "Breakpoint"},
            {"SYSCALL", "System Call"},
            {"TEQ", "Trap If Equal"},
            {"TEQI", "Trap If Equal Immediate"},
            {"TGE", "Trap If Greater Or Equal To"},
            {"TGEI", "Trap If Greater Or Equal To Immediate"},
            {"TGEIU", "Trap If Greater Or Equal To Immediate Unsigned"},
            {"TGEU", "Trap If Greater Or Equal To Unsigned"},
            {"TLT", "Trap If Less Than"},
            {"TLTI", "Trap If Less Than Immediate"},
            {"TLTIU", "Trap If Less Than Immediate Unsigned"},
            {"TLTU", "Trap If Less Than Unsigned"},
            {"TNE", "Trap If Not Equal"},
            {"TNEI", "Trap If Not Equal To Immediate"},
            {"CACHE", "Cache Operation"},
            {"DMFC0", "Double Move From COP0 Register"},
            {"DMTC0", "Double Move To Float COP0 Register"},
            {"ERET", "Return From Exception"},
            {"MFC0", "Move Word From COP0 Register"},
            {"MTC0", "Move Word To COP0 Register"},
            {"TLBP", "Probe TLB For Matching Entry"},
            {"TLBR", "Read Indexed TLB Entry"},
            {"TLBWI", "Write Indexed TLB Entry"},
            {"TLBWR", "Write Random TLB Entry"},
            {"C.F.S", "Float Compare Single False"},
            {"C.UN.S", "Float Compare Single Unordered"},
            {"C.EQ.S", "Float Compare Single Equal"},
            {"C.UEQ.S", "Float Compare Single Unordered or Equal"},
            {"C.OLT.S", "Float Compare Single Ordered or Less Than"},
            {"C.ULT.S", "Float Compare Single Unordered or Less Than"},
            {"C.OLE.S", "Float Compare Single Ordered or Less Than or Equal"},
            {"C.ULE.S", "Float Compare Single Unordered or Less Than or Equal"},
            {"C.SF.S", "Float Compare Single Signaling False"},
            {"C.NGLE.S", "Float Compare Single Not Greater Than or Less Than or Equal"},
            {"C.SEQ.S", "Float Compare Single Signaling Equal"},
            {"C.NGL.S", "Float Compare Single Not Greater Than or Less Than"},
            {"C.LT.S", "Float Compare Single Less Than"},
            {"C.NGE.S", "Float Compare Single Not Greater Than or Equal"},
            {"C.LE.S", "Float Compare Single Less Than or Equal"},
            {"C.NGT.S", "Float Compare Single Not Greater Than"},
            {"C.F.D", "Float Compare Double False"},
            {"C.UN.D", "Float Compare Double Unordered"},
            {"C.EQ.D", "Float Compare Double Equal"},
            {"C.UEQ.D", "Float Compare Double Unordered or Equal"},
            {"C.OLT.D", "Float Compare Double Ordered or Less Than"},
            {"C.ULT.D", "Float Compare Double Unordered or Less Than"},
            {"C.OLE.D", "Float Compare Double Ordered or Less Than or Equal"},
            {"C.ULE.D", "Float Compare Double Unordered or Less Than or Equal"},
            {"C.SF.D", "Float Compare Double Signaling False"},
            {"C.NGLE.D", "Float Compare Double Not Greater Than or Less Than or Equal"},
            {"C.SEQ.D", "Float Compare Double Signaling Equal"},
            {"C.NGL.D", "Float Compare Double Not Greater Than or Less Than"},
            {"C.LT.D", "Float Compare Double Less Than"},
            {"C.NGE.D", "Float Compare Double Not Greater Than or Equal"},
            {"C.LE.D", "Float Compare Double Less Than or Equal"},
            {"C.NGT.D", "Float Compare Double Not Greater Than"},
            {"ABS.S", "Float Absolute Word"},
            {"ABS.D", "Float Absolute Double"},
            {"ADD.S", "Float Add Word"},
            {"ADD.D", "Float Add Double"},
            {"BC1F", "Float Branch On False"},
            {"BC1FL", "Float Branch On False Likely"},
            {"BC1T", "Float Branch On True"},
            {"BC1TL", "Float Branch On True Likely"},
            {"CEIL.L.S", "Float Ceil Single Convert to Long Fixed"},
            {"CEIL.L.D", "Float Ceil Double Convert to Long Fixed"},
            {"CEIL.W.S", "Float Ceil Single Convert to Word Fixed"},
            {"CEIL.W.D", "Float Ceil Double Convert to Word Fixed"},
            {"CFC1", "Move Control Word from Float"},
            {"CTC1", "Move Control Word to Float"},
            {"CVT.D.S", "Float Convert Single to Double Float"},
            {"CVT.D.W", "Float Convert Word to Double Float"},
            {"CVT.D.L", "Float Convert Long to Double Float"},
            {"CVT.L.S", "Float Convert Single to Long Fixed"},
            {"CVT.L.D", "Float Convert Double to Long Fixed"},
            {"CVT.S.D", "Float Convert Double to Single Float"},
            {"CVT.S.W", "Float Convert Word to Single Float"},
            {"CVT.S.L", "Float Convert Long to Single Float"},
            {"CVT.W.S", "Float Convert Single to Word Fixed"},
            {"CVT.W.D", "Float Convert Word to Word Fixed"},
            {"DIV.S", "Float Divide Single"},
            {"DIV.D", "Float Divide Double"},
            {"DMFC1", "Double Move From Float"},
            {"DMTC1", "Double Move To Float"},
            {"FLOOR.L.S", "Float Floor Single Convert to Long Fixed"},
            {"FLOOR.L.D", "Float Floor Double Convert to Long Fixed"},
            {"FLOOR.W.S", "Float Floor Single Convert to Word Fixed"},
            {"FLOOR.W.D", "Float Floor Double Convert to Word Fixed"},
            {"LDC1", "Load Double to Float"},
            {"LWC1", "Load Word to Float"},
            {"MFC1", "Move Word from Float"},
            {"MOV.S", "Move Float Single"},
            {"MOV.D", "Move Float Double"},
            {"MTC1", "Move Word to Float"},
            {"MUL.S", "Float Multiply Single"},
            {"MUL.D", "Float Multiply Double"},
            {"NEG.S", "Float Negate Single"},
            {"NEG.D", "Float Negate Double"},
            {"ROUND.L.S", "Float Round Single to Long Fixed"},
            {"ROUND.L.D", "Float Round Double to Long Fixed"},
            {"ROUND.W.S", "Float Round Single to Word Fixed"},
            {"ROUND.W.D", "Float Round Double to Word Fixed"},
            {"SDC1", "Store Double from Float"},
            {"SQRT.S", "Float Square Root Single"},
            {"SQRT.D", "Float Square Rood Double"},
            {"SUB.S", "Float Subtract Single"},
            {"SUB.D", "Float Subtract Double"},
            {"SWC1", "Store Word from Float"},
            {"TRUNC.L.S", "Float Truncate Single to Long Fixed"},
            {"TRUNC.L.D", "Float Truncate Double to Long Fixed"},
            {"TRUNC.W.S", "Float Truncate Single to Word Fixed"},
            {"TRUNC.W.D", "Float Truncate Double to Word Fixed"}
        };
    }
}
