using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcadeProgramador
{
    class Operador
    {
        public decimal valor1 = 0, valor2 = 0, resultado;

        public void setarValoresEquacao(decimal val1, decimal val2)
        {
            valor2 = val2;
            valor1 = val1;
        }

        public string GeralLog(string operacao)
        {
            return $"Operação de {operacao} entre {valor1} e {valor2} = {resultado}";
        }

        public void Somar()
        {
            resultado = valor2 + valor1;
        }
        public void Subtrair()
        {
            resultado = valor1 - valor2;
        }
        public void Multiplicar()
        {
            resultado = valor1 * valor2;
        }

        public void Dividir()
        {
            if (valor2 == 0)
            {
                Console.WriteLine("Segundo Valor de uma divisão Não pode ser 0, tente novamente!");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                resultado = valor1 / valor2;
            }
        }
    }
}
