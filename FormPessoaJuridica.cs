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
    public partial class FormPessoaJuridica : Form
    {
        public FormPessoaJuridica()
        {
            InitializeComponent();
        }

        private void FormPessoaJuridica_Load(object sender, EventArgs e)
        {
            PessoaJuridica PJ = new PessoaJuridica
            {
                CNPJ = "58.814.505/0001-70",
                IE = "774.009.504.811",
                RazaoSocial = "DeVss",
                NomeFantasia = "Sem Limites Dev",
            };

            Pessoa Pessoa = new Pessoa
            {
                Nome = "Gabriel Dino e Barth",
                DataNascimento = new DateTime(13 / 12 / 2018),
                Endereco = "Rua Caminho São Lázaro",
                Telefone = "+55 (13) 3655-5747",
                Nacionalidade = "Brasileiro",
            };

            lblRespNomePJ.Text = Pessoa.Nome;
            lblRespDataNascimentoPJ.Text = Pessoa.DataNascimento.ToString();
            lblRespEnderecoPJ.Text = Pessoa.Endereco;
            lblRespTelefonePJ.Text = Pessoa.Telefone;
            lblRespNacionalidadePJ.Text = Pessoa.Nacionalidade;
            lblRespCNPJ.Text = PJ.CNPJ;
            lblRespIE.Text = PJ.IE;
            lblRespRazaoSocial.Text = PJ.RazaoSocial;
            lblRespNomeFantasia.Text = PJ.NomeFantasia;
        }
    }
}
