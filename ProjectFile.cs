using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z80Decompiler
{
    public class ProjectFile
    {
        private byte[] binaryFile;
        private List<DecodedLine> decodedLines = new List<DecodedLine>();

        //------------------------------------------------------

        public ProjectFile()
        {
            binaryFile = null;
        }

        //------------------------------------------------------

        ~ProjectFile()
        {
        }
                   
        //------------------------------------------------------
        // Attempt to load and process the binary file

        public bool Load(String filename)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.Open)) )
            {
                // Read the binary file
                binaryFile = reader.ReadBytes((int)reader.BaseStream.Length);

                // Now we need to process the file into text lines
                //Z80Decoder decoder = new Z80Decoder();

                // To start with lets assume every byte is a db
                for ( int i = 0; i < binaryFile.Length; i++)
                {
                    decodedLines.Add(new DecodedLine(binaryFile, i, 1));
                }
            }

            return true;
        }
    }
}
