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
    public partial class FormPessoaFisica : Form
    {
        public FormPessoaFisica()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void FormPessoaFisica_Load(object sender, EventArgs e)
        {
            PessoaFisica PF = new PessoaFisica
            {
                Peso = 60.47,
                Altura = 1.75,
                Sexo = "Masculino",
                CPF = "661.366.931-86",
            };
            Pessoa Pessoa = new Pessoa
            {
                Nome = "Gabriel Dino",
                DataNascimento = new DateTime(08/09/2005),
                Endereco =  "Rua Francelina",
                Telefone = "+55 (11) 95152-8301",
                Nacionalidade = "Brasileiro",
            };

            lblRespNome.Text = Pessoa.Nome;
            lblRespDataNascimento.Text = Pessoa.DataNascimento.ToString();
            lblRespEndereco.Text = Pessoa.Endereco;
            lblRespTelefone.Text = Pessoa.Telefone;
            lblRespNacionalidade.Text = Pessoa.Nacionalidade;
            lblRespPeso.Text = PF.Peso.ToString();
            lblRespAltura.Text = PF.Altura.ToString();
            lblRespSexo.Text = PF.Sexo;
            lblRespCPF.Text = PF.CPF;
        }
    }
}
