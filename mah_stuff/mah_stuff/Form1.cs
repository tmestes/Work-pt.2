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
                StreamReader inputFile;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = "c:\\Users\\testes\\Desktop\\showcase";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                //page 318

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFileDialog1.FileName);
                    storyTextBox.Text = "";
                    while (!inputFile.EndOfStream)
                    {
                        story = inputFile.ReadLine();

                        storyTextBox.Text += story + "\r\n";
                    }
                    inputFile.Close();
                }
                else
                {
                    MessageBox.Show("Operation cancelled.");
                    storyTextBox.Text = "";
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
