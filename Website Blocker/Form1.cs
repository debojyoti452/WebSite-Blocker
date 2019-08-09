using System;
using System.IO;
using System.Windows.Forms;

namespace Website_Blocker
{
    public partial class Form1 : Form
    {
        private String inputURL;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                inputURL = "\n127.0.0.1   " + urlInput.Text;
                using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts")))
                {
                    w.WriteLine(inputURL);
                    MessageBox.Show("Successfully done...");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);   
            }

        }

    }
}
