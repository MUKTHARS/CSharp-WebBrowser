using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWebBrowser
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Image Search Appers Here !");
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Video Serach Appers Here !");
        }

        private void mapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Maps Appear Here !");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void newsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your News Appear Here !");
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            NavigateToPage();
        }

        private void NavigateToPage() {
            metroButtonSearch.Enabled = false;
            metroTextBoxSearch.Enabled = false;
            webBrowser1.Navigate(metroTextBoxSearch.Text);
        }

        private void metroTextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter) {
                //NavigateToPage();
                metroButton1_Click_1(null,null);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            metroButtonSearch.Enabled = true;
            metroTextBoxSearch.Enabled = true;
        }
    }
}
