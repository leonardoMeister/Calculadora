using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcadeProgramador
{
    class TratadorMensagens
    {
        public void MostrarLog(string[] log)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            if (log[0] == null)
            {
                Console.WriteLine("Nenhuma Operação Realizada!");
            }
            else
                for (int i = 0; i < 100; i++)
                {
                    if (log[i] != null)
                    {
                        Console.WriteLine(log[i]);
                    }
                }
            Console.WriteLine("---------------------------------------------");
        }
        public decimal PegarValorer()
        {
            Console.Clear();
            while (true)
            {
                try
                {
                    decimal valor;
                    Console.Write("Insira um Valor para Equação: ");
                    valor = Convert.ToDecimal(Console.ReadLine());
                    return valor;
                }
                catch (Exception)
                {
                    Console.WriteLine("Insira Um Valor Valido!\n");
                    Console.ReadLine();
                }
            }
        }
        public int PedirOperazao()
        {
            int operacao = 0;
            do
            {
                try
                {
                    operacao = Convert.ToInt32(Console.ReadLine());
                    if (operacao >= 6 || operacao <= 0) Console.Write("Insira um valor entre 1 e 5: ");
                }
                catch (Exception)
                {
                    Console.Write("Insira um numero valido: ");
                }
            } while (operacao >= 6 || operacao <= 0);
            return operacao;
        }
        public void EcreverOpcoesMenu()
        {
            Console.WriteLine("Escolha a Operação:\n[1] Soma\n[2] Subtração\n[3] Divisão\n[4] Multiplicação\n[5] Log");
        }

    }
}
