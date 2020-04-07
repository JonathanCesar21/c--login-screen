using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
           
            pctPessoa.Image = Properties.Resources.pessoacertarosa;
            panel1.BackColor = Color.FromArgb(220, 20, 60);
            txtUsuario.ForeColor = Color.FromArgb(220, 20, 60);

            pctCadeado.Image = Properties.Resources.cadeadocerto;
            txtSenha.ForeColor = Color.FromArgb(220, 20, 60);
        }


        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            pctCadeado.Image = Properties.Resources.cadeadocertorosa;
            txtSenha.ForeColor = Color.FromArgb(220, 20, 60);

            pctPessoa.Image = Properties.Resources.pessoacerta;
            txtUsuario.ForeColor = Color.FromArgb(220, 20, 60);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
