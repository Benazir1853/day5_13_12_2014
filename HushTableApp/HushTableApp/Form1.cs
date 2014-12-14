using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HushTableApp
{
    public partial class Form1 : Form
    {

        Hashtable bookUI = new Hashtable();

public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (bookUI.ContainsKey(isbnToAddTextBox.Text) == true)
            {
                MessageBox.Show("this ISBN has been added before");
            }
            else
            {
                bookUI.Add(isbnToAddTextBox.Text, bookDetailsTextBox.Text);
                MessageBox.Show("Information Has been Saved");
            }

        }

        private void seachButton_Click(object sender, EventArgs e)
        {
            if (bookUI.ContainsKey(isbnToSearchTextBox.Text))
            {
            string bookdetails = Convert.ToString(bookUI[isbnToSearchTextBox.Text]);
                bookDetailsToSearchTextBox.Text = bookdetails;
            }
            else
            {
                MessageBox.Show("There is no book here with this Isbn");
            }

        }
    }
}
