using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<string> Fav = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnregre_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();


        }

        private void btnConti_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btnhom_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(webBrow.Text);
        }

        private void webBrow_Click(object sender, EventArgs e)
        {

        }

        private void btnFav_Click(object sender, EventArgs e)
        {
            Fav.Add(webBrowser1.Url.ToString());
            actualizarcmb();

        }

        private void actualizarcmb()
        {
            foreach (string direccion in Fav)
            {
                cmbFav.Items.Add(direccion);
            }

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
         //    webBrowser1.Navigate(cmbFav.SelectedItem.ToString());
        }

        private void cmbFav_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cmbFav.SelectedItem.ToString());
        }
    }
}
