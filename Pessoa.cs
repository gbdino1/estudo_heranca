using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_herancainterface_gabriel_nicolas
{
    class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Nacionalidade { get; set; }

        // método a ser sobrescrito (override)
        public virtual string DefinirNome(string Nome)
        {
            this.Nome = Nome;
            return $"Seu nome é {this.Nome}";
        }

        public string MostrarNome()
        {
            return this.Nome;
        }
    }
}
