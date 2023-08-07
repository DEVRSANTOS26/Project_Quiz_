using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rodrigo_Santos_5117
{
    internal class Program
    {

        static void Main(string[] args)
        {
            char opcao;
            char opcao2;
            char opcao3;
            char opcao5;
            char opcao4;
            string questoes;
            string questoes1;
            char sair;

            bool sair2 = false;

            int contadorgame = 0; // Contador para as vezes que o usuario jogou o meu quiz

            /* 
                Título do Projeto: Quiz (Geografia e Informatica)
                Autor: Rodrigo Santos
                Data: 28/04/2023
                Descrição: Projeto de Quiz focado no tema Geografia e Informatica.
            */


            // "FOR" PARA FAZER O ASPETO INICIAL
            do
            {
                for (int i = 1; i<=45; i++)
            {
                Console.Write("*");
            
            }
            Console.WriteLine("");
            Console.WriteLine("* Quiz v1.0 - Rodrigo Santos | Menu Inicial *");



            for (int i = 1; i <= 45; i++)
            {
                Console.Write("*");

            } Console.Write("2023");

            Console.WriteLine("\n");

                // MENU PRINCIPAL
                Console.WriteLine("1. Nivel Dificuldade - Inicial");
                Console.WriteLine("2. Nivel Dificuldade - Avançado");
                Console.WriteLine("3. Instruções de utilização do Quiz");
                Console.WriteLine("4. Sair do Quiz");
                Console.Write("R: ");
                opcao = char.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case '1':
                        // NIVEL INICIAL
                        int contador = 0; // CONTADOR PARA AS QUESTÕES VERDADEIRAS
                        int contador1 = 0; // CONTADOR PARA AS QUESTÕES FALSAS
                        Console.Clear();
                        Console.WriteLine("Nível Incial");
                        Console.WriteLine("*************\n");
                        contadorgame++;


                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("1 - O rato é um dispositivo de Entrada: ");
                        questoes = Console.ReadLine();

                        if (questoes == "v" || questoes == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador++;
                        }

                        else if (questoes == "f" || questoes == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador1++;
                        }

                        while ((questoes != "v") && (questoes != "V") && (questoes != "f") && (questoes != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("1 - O rato é um dispositivo de Entrada: ");
                            questoes = Console.ReadLine();
                            if (questoes == "v" || questoes == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador++;
                            }
                            else if (questoes == "f" || questoes == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador1++;
                            }


                        }



                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("2 - O Teclado é um dispositivo de saída: ");
                        questoes = Console.ReadLine();



                        if (questoes == "f" || questoes == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador++;
                        }

                        else if (questoes == "v" || questoes == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador1++;
                        }

                        while ((questoes != "v") && (questoes != "V") && (questoes != "f") && (questoes != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("2 - O Teclado é um dispositivo de saída: ");
                            questoes = Console.ReadLine();
                            if (questoes == "f" || questoes == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador++;
                            }
                            else if (questoes == "v" || questoes == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador1++;
                            }
                        }


                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("3 - A impressora Multifuncional é um dispositivo de Entrada e Saída: ");
                        questoes = Console.ReadLine();



                        if (questoes == "v" || questoes == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador++;
                        }

                        else if (questoes == "f" || questoes == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador1++;
                        }

                        

                        while ((questoes != "v") && (questoes != "V") && (questoes != "f") && (questoes != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("3 - A impressora Multifuncional é um dispositivo de Entrada e Saída: ");
                            questoes = Console.ReadLine();
                            if (questoes == "v" || questoes == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador++;
                            }
                            else if (questoes == "f" || questoes == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador1++;
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("4 - O monitor é um dispositivo de Saída: ");
                        questoes = Console.ReadLine();



                        if (questoes == "f" || questoes == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador++;
                        }

                        else if (questoes == "v" || questoes == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador1++;
                        }

                        while ((questoes != "v") && (questoes != "V") && (questoes != "f") && (questoes != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("4 - O monitor é um dispositivo de Saída: ");
                            questoes = Console.ReadLine();
                            if (questoes == "f" || questoes == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador++;
                            }
                            else if (questoes == "v" || questoes == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador1++;
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("5 - O computador é útil para os nossos estudos cotidianos: ");
                        questoes = Console.ReadLine();



                        if (questoes == "v" || questoes == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador++;
                        }

                        else if (questoes == "f" || questoes == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador1++;
                        }

                        while ((questoes != "v") && (questoes != "V") && (questoes != "f") && (questoes != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("5 - O computador é útil para os nossos estudos cotidianos: ");
                            questoes = Console.ReadLine();
                            if (questoes == "v" || questoes == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador++;
                            }
                            else if (questoes == "f" || questoes == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador1++;
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("6 - Posso usar um computador direto na tomada 220v sem um estabilizador: ");
                        questoes = Console.ReadLine();



                        if (questoes == "f" || questoes == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador++;
                        }

                        else if (questoes == "v" || questoes == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador1++;
                        }

                        while ((questoes != "v") && (questoes != "V") && (questoes != "f") && (questoes != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("6 - Posso usar um computador direto na tomada 220v sem um estabilizador: ");
                            questoes = Console.ReadLine();
                            if (questoes == "f" || questoes == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador++;
                            }
                            else if (questoes == "v" || questoes == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador1++;
                            }
                        }


                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("7 - Os computadores, conseguem funcionar somente com periféricos: ");
                        questoes = Console.ReadLine();



                        if (questoes == "f" || questoes == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador++;
                        }

                        else if (questoes == "v" || questoes == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador1++;
                        }

                        while ((questoes != "v") && (questoes != "V") && (questoes != "f") && (questoes != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("7 - Os computadores, conseguem funcionar somente com periféricos: ");
                            questoes = Console.ReadLine();
                            if (questoes == "f" || questoes == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador++;
                            }

                            else if (questoes == "v" || questoes == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador1++;
                            }

                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("8 - As máquinas são formadas por dois tipos de componentes: software e hardware: ");
                        questoes = Console.ReadLine();



                        if (questoes == "v" || questoes == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador++;
                        }

                        else if (questoes == "f" || questoes == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador1++;
                        }

                        while ((questoes != "v") && (questoes != "V") && (questoes != "f") && (questoes != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("8 - As máquinas são formadas por dois tipos de componentes: software e hardware: ");
                            questoes = Console.ReadLine();
                            if (questoes == "v" || questoes == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador++;
                            }
                            else if (questoes == "f" || questoes == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador1++;
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("9 - Os softwares representam todas as instruções que a máquina recebe pelo usuário para que uma determinada tarefa seja executada: ");
                        questoes = Console.ReadLine();



                        if (questoes == "v" || questoes == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador++;
                        }

                        else if (questoes == "f" || questoes == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador1++;
                        }

                        while ((questoes != "v") && (questoes != "V") && (questoes != "f") && (questoes != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("9 - Os softwares representam todas as instruções que a máquina recebe pelo usuário para que uma determinada tarefa seja executada: ");
                            questoes = Console.ReadLine();
                            if (questoes == "v" || questoes == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador++;
                            }
                            else if (questoes == "f" || questoes == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador1++;
                            }

                        }


                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("10 - O Windows é um SO totalmente gratuito: ");
                        questoes = Console.ReadLine();



                        if (questoes == "f" || questoes == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador++;
                        }

                        else if (questoes == "v" || questoes == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador1++;
                        }

                        while ((questoes != "v") && (questoes != "V") && (questoes != "f") && (questoes != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("10 - O Windows é um SO totalmente gratuito: ");
                            questoes = Console.ReadLine();
                            if (questoes == "f" || questoes == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador++;
                            }
                            else if (questoes == "v" || questoes == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador1++;
                            }
                        }

                        


                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("1. Pretende ver o Total de Respostas Certas?");
                        Console.WriteLine("2. Pretende Jogar Novamente?");
                        Console.Write("R: ");
                        opcao2 = char.Parse(Console.ReadLine());



                        if (opcao2 == '1')
                        {
                            Console.Clear();
                            Console.WriteLine("Total Respostas Certas: " + contador);
                            Console.WriteLine("Total Respostas Incorretas: " + contador1);

                            Console.WriteLine("\nDeseja Sair do Programa?\n 1 - Sim\n 2 - Não");
                            Console.Write("R: ");
                            opcao5 = char.Parse(Console.ReadLine());

                            if (opcao5 == '1')
                            {
                                Console.Clear();
                                Console.WriteLine($"Obrigado por ter jogado {contadorgame} vezes o meu quiz!");
                                Console.WriteLine();

                                Console.WriteLine("O programa vai ser Desligado Dentro de Momentos!");
                                Thread.Sleep(3000);
                                Environment.Exit(0);
                            }

                            if (opcao5 == '2')
                            {
                                Console.WriteLine("Retornar ao Menu Inicial\n");
                            }


                        }
                        if (opcao2 == '2')
                        {
                            Console.WriteLine("\n1 - Sim\n 2 - Não");
                            Console.Write("R: ");
                            opcao4 = char.Parse(Console.ReadLine());
                            if (opcao4 == '1')
                            {
                                Console.WriteLine("Retornar ao Menu Inicial \n");
                            }
                            if (opcao4 == '2')
                            {
                                Console.Clear();
                                Console.WriteLine($"Obrigado por ter jogado {contadorgame} vezes o meu quiz!");
                                Console.WriteLine();

                                Console.WriteLine("O programa vai ser Desligado Dentro de Momentos!");
                                Thread.Sleep(3000);
                                Environment.Exit(0);


                            }

                        }

                        while ((opcao2 != '1') && (opcao2 != '2'))
                           {
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Tente Novamente !");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("1. Pretende ver o Total de Respostas Certas?");
                            Console.WriteLine("2. Pretende Jogar Novamente?");
                            Console.Write("R: ");
                            opcao2 = char.Parse(Console.ReadLine());
                            if (opcao2 == '1')
                            {
                                Console.WriteLine("Total Respostas Certas: " + contador);
                                Console.WriteLine("Total Respostas Incorretas: " + contador1);
                            }
                            if (opcao2 == '2')
                            {
                              //  Console.WriteLine("Deseja Sair? Se Sim Prima Qualquer Tecla!");
                            }

                           }



                       
                            break;
                        
                    case '2':
                        // NIVEL AVANÇADO
                        int contador3 = 0; // CONTADOR PARA A RESPOSTA CERTA
                        int contador4 = 0; // CONTADOR PARA A RESPOSTA ERRADA
                        contadorgame++;
                        Console.Clear();
                        Console.WriteLine("Nível Avançado");
                        Console.WriteLine("*************");


                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("1 - A cidade de Nova York é composta de 36 a 42 ilhas: ");
                        questoes1 = Console.ReadLine();



                        if (questoes1 == "v" || questoes1 == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador3++;
                        }

                        else if (questoes1 == "f" || questoes1 == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador4++;
                        }

                        while ((questoes1 != "v") && (questoes1 != "V") && (questoes1 != "f") && (questoes1 != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("1 - A cidade de Nova York é composta de 36 a 42 ilhas: ");
                            questoes1 = Console.ReadLine();
                            if (questoes1 == "v" || questoes1 == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador3++;
                            }
                            else if (questoes1 == "v" || questoes1 == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador4++;
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("2 - A África do Sul tem uma capital: ");
                        questoes1 = Console.ReadLine();



                        if (questoes1 == "f" || questoes1 == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador3++;
                        }

                        else if (questoes1 == "v" || questoes1 == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador4++;
                        }

                        while ((questoes1 != "v") && (questoes1 != "V") && (questoes1 != "f") && (questoes1 != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("2 - A África do Sul tem uma capital: ");
                            questoes1 = Console.ReadLine();
                            if (questoes1 == "f" || questoes1 == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador3++;
                            }
                            else if (questoes1 == "v" || questoes1 == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador4++;
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("3 - O Oceano Atlântico é o maior oceano da Terra: ");
                        questoes1 = Console.ReadLine();



                        if (questoes1 == "f" || questoes1 == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador3++;
                        }

                        else if (questoes1 == "v" || questoes1 == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador4++;
                        }

                        while ((questoes1 != "v") && (questoes1 != "V") && (questoes1 != "f") && (questoes1 != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("3 - O Oceano Atlântico é o maior oceano da Terra: ");
                            questoes1 = Console.ReadLine();
                            if (questoes1 == "f" || questoes1 == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador3++;
                            }
                            else if (questoes1 == "v" || questoes1 == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador4++;
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("4 - O Monte Everest é a montanha mais alta do mundo: ");
                        questoes1 = Console.ReadLine();



                        if (questoes1 == "v" || questoes1 == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador3++;
                        }

                        else if (questoes1 == "f" || questoes1 == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador4++;
                        }

                        while ((questoes1 != "v") && (questoes1 != "V") && (questoes1 != "f") && (questoes1 != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("4 - O Monte Everest é a montanha mais alta do mundo: ");
                            questoes1 = Console.ReadLine();
                            if (questoes1 == "v" || questoes1 == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador3++;
                            }
                            else if (questoes1 == "f" || questoes1 == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador4++;
                            }
                        }



                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("5 - O comprimento total da Grande Muralha da China soma 13.171 milhas: ");
                        questoes1 = Console.ReadLine();



                        if (questoes1 == "v" || questoes1 == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador3++;
                        }

                        else if (questoes1 == "f" || questoes1 == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador4++;
                        }

                        while ((questoes1 != "v") && (questoes1 != "V") && (questoes1 != "f") && (questoes1 != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("5 - O comprimento total da Grande Muralha da China soma 13.171 milhas: ");
                            questoes1 = Console.ReadLine();
                            if (questoes1 == "v" || questoes1 == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador3++;
                            }
                            else if (questoes1 == "f" || questoes1 == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador4++;
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("6 - Os dois maiores rios do mundo são o Mississippi e o Nilo: ");
                        questoes1 = Console.ReadLine();



                        if (questoes1 == "f" || questoes1 == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador3++;
                        }

                        else if (questoes1 == "v" || questoes1 == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador4++;
                        }

                        while ((questoes1 != "v") && (questoes1 != "V") && (questoes1 != "f") && (questoes1 != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("6 - Os dois maiores rios do mundo são o Mississippi e o Nilo: ");
                            questoes1 = Console.ReadLine();
                            if (questoes1 == "f" || questoes1 == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador3++;
                            }
                            else if (questoes1 == "v" || questoes1 == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador4++;
                            }
                        }



                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("7 - O túnel entre a Inglaterra e a França tem 31,5 milhas de comprimento: ");
                        questoes1 = Console.ReadLine();



                        if (questoes1 == "v" || questoes1 == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador3++;
                        }

                        else if (questoes1 == "f" || questoes1 == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador4++;
                        }

                        while ((questoes1 != "v") && (questoes1 != "V") && (questoes1 != "f") && (questoes1 != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("7 - O túnel entre a Inglaterra e a França tem 31,5 milhas de comprimento: ");
                            questoes1 = Console.ReadLine();
                            if (questoes1 == "v" || questoes1 == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador3++;
                            }
                            else if (questoes1 == "f" || questoes1 == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador4++;
                            }
                        }



                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("8 - A Groenlândia é a maior ilha do mundo: ");
                        questoes1 = Console.ReadLine();



                        if (questoes1 == "v" || questoes1 == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador3++;
                        }

                        else if (questoes1 == "f" || questoes1 == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador4++;
                        }

                        while ((questoes1 != "v") && (questoes1 != "V") && (questoes1 != "f") && (questoes1 != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("8 - A Groenlândia é a maior ilha do mundo: ");
                            questoes1 = Console.ReadLine();
                            if (questoes1 == "v" || questoes1 == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador3++;
                            }
                            else if (questoes1 == "f" || questoes1 == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador4++;
                            }
                        }


                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("9 - Existem mais países na América do Sul do que na África: ");
                        questoes1 = Console.ReadLine();



                        if (questoes1 == "f" || questoes1 == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador3++;
                        }

                        else if (questoes1 == "v" || questoes1 == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador4++;
                        }

                        while ((questoes1 != "v") && (questoes1 != "V") && (questoes1 != "f") && (questoes1 != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("9 - Existem mais países na América do Sul do que na África: ");
                            questoes1 = Console.ReadLine();
                            if (questoes1 == "f" || questoes1 == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador3++;
                            }
                            else if (questoes1 == "v" || questoes1 == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador4++;
                            }
                        }



                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("10 - O Alasca tem os vulcões mais ativos de qualquer estado dos Estados Unidos: ");
                        questoes1 = Console.ReadLine();



                        if (questoes1 == "v" || questoes1 == "V")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Resposta Correta!");
                            contador3++;
                        }

                        else if (questoes1 == "f" || questoes1 == "F")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resposta Incorreta!");
                            contador4++;
                        }

                        while ((questoes1 != "v") && (questoes1 != "V") && (questoes1 != "f") && (questoes1 != "F"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalido!");
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("10 - O Alasca tem os vulcões mais ativos de qualquer estado dos Estados Unidos: ");
                            questoes1 = Console.ReadLine();
                            if (questoes1 == "v" || questoes1 == "V")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Resposta Correta!");
                                contador3++;
                            }
                            else if (questoes1 == "f" || questoes1 == "F")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Resposta Incorreta!");
                                contador4++;
                            }
                        }

               

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("1. Pretende ver o Total de Respostas Certas?");
                        Console.WriteLine("2. Pretende Jogar Novamente?");
                        Console.Write("R: ");
                        opcao3 = char.Parse(Console.ReadLine());

                        if (opcao3 == '1')
                        {
                            Console.Clear();
                            Console.WriteLine("Total Respostas Certas: " + contador3);
                            Console.WriteLine("Total Respostas Incorretas: " + contador4);

                            Console.WriteLine("\nDeseja Sair do Programa?\n 1 - Sim\n 2 - Não");
                            Console.Write("R: ");
                            opcao5 = char.Parse(Console.ReadLine());
                        
                            if(opcao5 == '1')
                            {
                                Console.Clear();
                                Console.WriteLine($"Obrigado por ter jogado {contadorgame} vezes o meu quiz!");
                                Console.WriteLine();

                                Console.WriteLine("O programa vai ser Desligado Dentro de Momentos!");
                                Thread.Sleep(3000);
                                Environment.Exit(0);
                            }

                            if(opcao5 == '2')
                            {
                                Console.WriteLine("Retornar ao Menu Inicial\n");
                            }


                        }
                        if (opcao3 == '2')
                        {
                            Console.WriteLine("\n1 - Sim\n 2 - Não");
                            Console.Write("R: ");
                            opcao4 = char.Parse(Console.ReadLine());
                            if(opcao4 == '1')
                            {
                                Console.WriteLine("Retornar ao Menu Inicial \n");
                            }
                            if(opcao4 == '2')
                            {
                                Console.Clear();
                                Console.WriteLine($"Obrigado por ter jogado {contadorgame} vezes o meu quiz!");
                                Console.WriteLine();

                                Console.WriteLine("O programa vai ser Desligado Dentro de Momentos!");
                                Thread.Sleep(3000);
                                Environment.Exit(0);


                            }


                        }


                        while ((opcao3 != '1') && (opcao3 != '2'))
                        {
                            Console.WriteLine("\a");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Tente Novamente !");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("1. Pretende ver o Total de Respostas Certas?");
                            Console.WriteLine("2. Pretende Jogar Novamente?");
                            Console.Write("R: ");
                            opcao3 = char.Parse(Console.ReadLine());
                            if (opcao3 == '1')
                            {
                                Console.Clear();
                                Console.WriteLine("Total Respostas Certas: " + contador3);
                                Console.WriteLine("Total Respostas Incorretas: " + contador4);

                                Console.WriteLine("\nDeseja Sair do Programa?\n 1 - Sim\n 2 - Não");
                                Console.Write("R: ");
                                opcao5 = char.Parse(Console.ReadLine());

                                if (opcao5 == '1')
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Obrigado por ter jogado {contadorgame} vezes o meu quiz!");
                                    Console.WriteLine();

                                    Console.WriteLine("O programa vai ser Desligado Dentro de Momentos!");
                                    Thread.Sleep(3000);
                                    Environment.Exit(0);
                                }


                                if (opcao5 == '2')
                                {
                                    Console.WriteLine("Retornar ao Menu Inicial\n");
                                }

                            }

                                if (opcao3 == '2')
                                {
                             
                                    Console.WriteLine("Deseja Sair do Programa?\n 1 - Sim\n 2 - Não");
                                    Console.Write("R: ");
                                    opcao4 = char.Parse(Console.ReadLine());

                                    if (opcao4 == '1')
                                    {
                                        Console.WriteLine("Retornar ao Menu Inicial \n");
                                    }
                                    if (opcao4 == '2')
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"Obrigado por ter jogado {contadorgame} vezes o meu quiz!");
                                        Console.WriteLine();

                                        Console.WriteLine("O programa vai ser Desligado Dentro de Momentos!");
                                        Thread.Sleep(2000);
                                        Environment.Exit(0);


                                    }
                                }

                        }
                           
                        
                        break;

                    case '3':
                        Console.Clear();
                        Console.WriteLine("Quiz Intruções: Olá Jogador neste quiz vai ser representado varias questões com dois níveis de dificuldade (Inicial/Avançado) os temas representados são: Informatica e Geografia, contudo, teras que responder com um V ou F (Verdadeiro ou Falso).");
                        break;

                    case '4':
                       
                            Environment.Exit(0); // SAIR DO PROGRAMA
                       
                        break;
                    default:
                        Console.WriteLine("\a");
                        Console.WriteLine("Opção Invalida!");
                        break;

                }
                Console.WriteLine("Prima qualquer tecla para avançar!");
                Console.ReadKey();
                Console.Clear();
            } while (true);

        }
    }
}
