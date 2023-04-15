using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_herancainterface_gabriel_nicolas
{
    interface IRecursos
    {
        // definir o contrato para os métodos.
        string Falar(string Falar);
        void Parar();
        string Andar();
    }
}
