using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace KlasaArraylistGabrielMatosevic
{
    public partial class Form1 : Form
    {
        ArrayList listaAutomobila = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void NoviAutoButton_Click(object sender, EventArgs e)
        {
            UpperTextBox.Enabled = true;
            UnesiButton.Enabled = true;
        }

        private void UnesiButton_Click(object sender, EventArgs e)
        {
            Automobil Auto = new Automobil(UpperTextBox.Text);
            listaAutomobila.Add(Auto);
            LowerRichTextBox.AppendText(listaAutomobila.IndexOf(Auto) + 1 + ". " + Auto.DajMarku() + "\n");
            UpperTextBox.Text = "";
            UpperTextBox.Enabled = false;
            UnesiButton.Enabled = false;
        }

        private void ObrisiListuButton_Click(object sender, EventArgs e)
        {
            listaAutomobila.Clear();
            LowerRichTextBox.Text = "";
            UpperTextBox.Text = "";
        }
    }
}
