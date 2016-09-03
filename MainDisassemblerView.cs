using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z80Decompiler
{
    public partial class MainDisassemblerView : Form
    {
        private ProjectFile projectFile;

        public MainDisassemblerView()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a new project file
                projectFile = new ProjectFile();

                try
                {
                    // Try and process the file
                    projectFile.Load(openFileDialog.FileName);
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("Failed to open and process the file: {0}", ex.ToString());
                }
            }

            // Clear the text
            disassemblerView.Text = null;

            // Now we need to add all the new decoded lines in

        }
    }
}
