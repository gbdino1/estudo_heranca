using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_herancainterface_gabriel_nicolas
{
    class PessoaFisica: Pessoa, IRecursos
    {
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Sexo { get; set; }
        public string CPF { get; set; }

        // método que sobrescreve (override)
        public override string DefinirNome(string Nome)
        {
            this.Nome = Nome;
            return $"O nome da pessoa física é: {this.Nome}";
        }

        // implementando a interface
        string IRecursos.Andar()
        {
            return $"Estou andando.";
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
