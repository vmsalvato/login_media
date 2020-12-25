using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_media
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double x1, x2, x3, media;
            x1 = Convert.ToDouble(txtMedia1.Text);
            x2 = Convert.ToDouble(txtMedia2.Text);
            x3 = Convert.ToDouble(txtMedia3.Text);
            media = (x1 + x2 + x3) / 3;
            txtMedia.Text = media.ToString();

            if (media >= 7) {
                MessageBox.Show("Aprovado! Média: " + media, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else {
                MessageBox.Show("Reprovado! Média: " + media, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMedia1.Text = "";
            txtMedia2.Text = "";
            txtMedia3.Text = "";
            txtMedia.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
