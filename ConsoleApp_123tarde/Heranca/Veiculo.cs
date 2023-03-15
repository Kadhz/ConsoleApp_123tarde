using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp_123tarde.Heranca
{
    public class Veiculo
    {
        public string cor;
        public int quantidadedeRodas;
        public int quantidadedeAcentos;
        public bool TemMotor;

        public string ExibirDados()
        {
            if (TemMotor)
            {
                return "Tem motor" + cor + " " + quantidadedeAcentos + " " + quantidadedeRodas;
            }

            return cor + " " + quantidadedeAcentos + " " + quantidadedeRodas;
        }
    }
}
