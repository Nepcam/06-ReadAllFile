using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReadAllFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will open and read the contents of file called \"party list.txt\"");
            // create the input stream and open file called "party list.txt" 
            StreamReader inputFile;
            inputFile = File.OpenText("party list.txt");
            string contents = "";
            while (!inputFile.EndOfStream)
            {
                contents += inputFile.ReadLine() + "\n";
            }
            MessageBox.Show(contents);
            // close the stream/file
            inputFile.Close();
        }
    }
}
