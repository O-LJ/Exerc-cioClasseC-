using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Veiculo
    {
        public decimal Velocidade { get; set; }
        public string NovaVelocidade { get; set; }
        public void AlterarVelocidade(decimal NovaVelocidade)

        {
            if (NovaVelocidade > 200 || NovaVelocidade < 0)
            {
                Console.WriteLine("Velocidade fora do limite permitido.");
            }
            else
            {
                Velocidade = NovaVelocidade;
                Console.WriteLine(Velocidade);
            }
        }
    }
}