using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; private set; }

        public void AumentarSalario(decimal percentual)
        {
        decimal aumento = Salario * percentual / 100;
        Salario += aumento;
        }
        public void ConsultarSalario()
        {
            Console.WriteLine($"O salário do funcionário {Nome} é: R$ {Salario}");
        }
    }
}