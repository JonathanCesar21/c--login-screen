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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuarioRegistro_Click(object sender, EventArgs e)
        {
            txtUsuarioRegistro.Clear();

            pctPessoa.Image = Properties.Resources.pessoacertarosa;
            panel1.BackColor = Color.FromArgb(220, 20, 60);
            txtUsuarioRegistro.ForeColor = Color.FromArgb(220, 20, 60);

            pctCadeado.Image = Properties.Resources.cadeadocerto;
            txtSenhaRegistro.ForeColor = Color.FromArgb(220, 20, 60);
        }
    }
}
