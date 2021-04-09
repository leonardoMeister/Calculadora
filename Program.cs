using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcadeProgramador
{
    class Program
    {
    
        static void Main(string[] args)
        {
            float valor1 = 0, valor2 = 0;
            String x = "S";     
            float res = 0;
            int cont = 0;
            String[] log = new string[100];
            while (x == "S" || x == "s")
            {
                int operacao = 0;
                string equacao = "";

                //escrevendo o menu
                EcreverOpcoesMenu();

                //Tratamento Coleta de Opção
                operacao = PedirOperazao();

                if (!(EhOpcaoLog(operacao)))
                {
                    //pegando valores e validando
                    PegarValoresUsuario(ref valor1, ref valor2);
                }

                //Identificador de Opções do menu
                switch (operacao)
                {
                    case 1:
                        res = valor1 + valor2;
                        equacao = "Soma de " + valor1 + " e " + valor2 + " = " + res;
                        Console.WriteLine(equacao);
                        RegistrarLog(equacao, log, cont);

                        break;
                    case 2:
                        res = valor1 - valor2;
                        equacao = "Subtração de " + valor1 + " e " + valor2 + " = " + res;
                        Console.WriteLine(equacao);
                        RegistrarLog(equacao, log, cont);
                        break;
                    case 3:
                        //não realizando a operação caso seja 0 o segundo valor
                        if (valor2 == 0)
                        {
                            Console.WriteLine("Segundo Valor de uma divisão Não pode ser 0, tente novamente!");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        //caso de certo a operação acontece
                        res = valor1 / valor2;
                        equacao = "Divisão de " + valor1 + " e " + valor2 + " = " + res;
                        Console.WriteLine(equacao);
                        RegistrarLog(equacao, log, cont);
                        break;
                    case 4:
                        res = valor1 * valor2;
                        equacao = "Multiplicação de " + valor1 + " e " + valor2 + " = " + res;
                        Console.WriteLine(equacao);
                        RegistrarLog(equacao, log, cont);
                        break;
                    case 5:
                        //quando mostra o log não pode incrementar cont
                        MostrarLog(log);
                        x = PerguntaSimNao();
                        Console.Clear();
                        continue; // para pular o incremento de cont
                }

                //Mantendo ou fechando o ciclo
                x = PerguntaSimNao();
                //limpando a tela
                Console.Clear();
                //incrementando contador
                cont++;
            }
        }
        //Metodos------------------------------------------------------------------------------------------------------//
        private static void EcreverOpcoesMenu()
        {
            Console.WriteLine("Escolha a Operação:\n[1] Soma\n[2] Subtração\n[3] Divisão\n[4] Multiplicação\n[5] Log");
        }
        private static int PedirOperazao()
        {
            int operacao=0;
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
        private static string PerguntaSimNao()
        {
            string x;
            do
            {
                Console.WriteLine("\nVocê deseja realizar outra operação? [S] [N]");
                x = Console.ReadLine();
                if (!(x == "S" || x == "N" || x == "s" || x == "n")) Console.WriteLine("Insira um valor valido! \n");
            } while (!(x == "S" || x == "N" || x == "s" || x == "n"));
            return x;
        }
        private static bool EhOpcaoLog(int operacao)
        {
            return operacao == 5;
        }
        private static void PegarValoresUsuario(ref float valor1, ref float valor2)
        {
            Console.Clear();
            bool pegarValor = true;
            while (pegarValor)
            {
                try
                {
                    Console.Write("Insira o Primeiro Valor da Equação: ");
                    valor1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Insira o Segundo Valor Da Equação: ");
                    valor2 = Convert.ToInt32(Console.ReadLine());
                    //saindo do Loop se der tudo certo
                    pegarValor = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Insira Um Valor Valido!\n");
                }
            }
        }
        private static void RegistrarLog(String operacao, String[] log, int cont)
        {
            log[cont] = operacao;
        }
        private static void MostrarLog(string[] log)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            if (log[0] == null)
            {
                Console.WriteLine("Nenhuma Operação Realizada!");
            } else
            for (int i = 0; i < 100 ; i++)
            {
                if (log[i] != null)
                {
                        Console.WriteLine(log[i]);
                }
            }
            Console.WriteLine("---------------------------------------------");
        }
    }
}