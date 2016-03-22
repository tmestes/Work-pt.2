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

namespace mah_stuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                string story;
                OpenFileDialog openFile;
                StreamReader inputFile;
                //page 310

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFile.FileName);

                    storyTextBox.Text = story;
                }
                else
                {
                    MessageBox.Show("Operation cancelled.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void closeFileButton_Click(object sender, EventArgs e)
        {
            storyTextBox.Text = "";
        }
    }
}
