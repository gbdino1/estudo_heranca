using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_herancainterface_gabriel_nicolas
{
    class PessoaJuridica: Pessoa, IRecursos
    {
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }

        // método que sobrescreve (override)
        public override string DefinirNome(string Nome)
        {
            this.Nome = Nome;
            return $"O nome da pessoa jurídica é: {this.Nome}";
        }

        // implementando a interface
        string IRecursos.Andar()
        {
            return $"Estou andando e sou uma pessoa jurídica.";
        }

        string IRecursos.Falar(string Falar)
        {
            return $"Estou falando";
        }

        void IRecursos.Parar()
        {

        }
    }
}
