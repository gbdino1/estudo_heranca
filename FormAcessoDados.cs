using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_herancainterface_gabriel_nicolas
{
    public partial class FormAcessoDados : Form
    {
        public FormAcessoDados()
        {
            InitializeComponent();
        }

        private void btnPessoaFisica_Click(object sender, EventArgs e)
        {
            FormPessoaFisica FPF = new FormPessoaFisica();
            FPF.Show();
        }

        private void btnPessoaJuridica_Click(object sender, EventArgs e)
        {
            FormPessoaJuridica FPJ = new FormPessoaJuridica();
            FPJ.Show();
        }

        private void FormAcessoDados_Load(object sender, EventArgs e)
        {

        }
    }
}
