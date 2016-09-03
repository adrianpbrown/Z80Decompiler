using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z80Decompiler
{
    public class DecodedLine
    {
        private int binaryOffset;
        private int binaryLength;

        public DecodedLine(byte [] binaryFile, int offset, int length)
        {
            binaryOffset = offset;
            binaryLength = length;
        }
    }
}
