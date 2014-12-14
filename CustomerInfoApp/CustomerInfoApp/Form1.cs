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

namespace CustomerInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string name = customerInfoText.Text;
        string path = @"H:\info.txt";

        private void saveButton_Click(object sender, EventArgs e)
        {

            FileStream aFileStream = new FileStream(path, FileMode.Append);
            StreamWriter astStreamWriter = new StreamWriter(aFileStream);
            astStreamWriter.Write(name);
            astStreamWriter.WriteLine();
            astStreamWriter.Close();
            aFileStream.Close();



        }
    }
}
