using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcadeProgramador
{
    class Program
    {

        TratadorMensagens tratador = new TratadorMensagens();
        Operador ope = new Operador();
        int cont = 0;
        String[] log = new string[100];

        public Program()
        {
            String x = "S";

            while (x.ToUpper().Equals("S"))
            {
                int operacao = 0;

                //escrevendo o menu
                tratador.EcreverOpcoesMenu();

                //Tratamento Coleta de Opção
                operacao = tratador.PedirOperazao();

                if (!(EhOpcaoLog(operacao)))
                {
                    //pegando valores e validando
                    ope.setarValoresEquacao(tratador.PegarValorer(), tratador.PegarValorer());
                }

                //Identificador de Opções do menu
                switch (operacao)
                {
                    case 1:
                        ope.Somar();
                        RegistrarLog(ope.GeralLog("Soma"), log, cont);
                        Console.WriteLine(ope.GeralLog("Soma"));
                        break;
                    case 2:
                        ope.Subtrair();

                        RegistrarLog(ope.GeralLog("Subtração"), log, cont);
                        Console.WriteLine(ope.GeralLog("Subtração"));

                        break;
                    case 3:
                        ope.Dividir();
                        if (!(ope.valor2 == 0))
                        {
                            RegistrarLog(ope.GeralLog("Divisão"), log, cont);
                            Console.WriteLine(ope.GeralLog("Divisão"));
                        }
                        break;
                    case 4:
                        ope.Multiplicar();
                        RegistrarLog(ope.GeralLog("Multiplicação"), log, cont);
                        Console.WriteLine(ope.GeralLog("Divisão"));

                        break;
                    case 5:
                        //quando mostra o log não pode incrementar cont
                        tratador.MostrarLog(log);
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

        static void Main(string[] args)
        {
            new Program();
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

        private static void RegistrarLog(String operacao, String[] log, int cont)
        {
            log[cont] = operacao;
        }
        
    }
}