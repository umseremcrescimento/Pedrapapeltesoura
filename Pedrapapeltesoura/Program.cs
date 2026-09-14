using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pedrapapeltesoura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int life = 0;
            int stamina = 0;
            int life2 = 0;
            int stamina2 = 0;
            Random sorteador = new Random();
            int tipoGolpe = 0;
            Random sorteador2 = new Random();
            int tipoGolpe2 = 0;
            int gasto = 0;
            int gasto2 = 0;
            int cooldownEspecial = 0;
            bool especial = true;
            bool especial2 = true;

            Console.WriteLine();
            Console.WriteLine("====================================================");
            Console.WriteLine("Bem vindo estudante! Me diga seu nome na matricula:");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            string username = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("====================================================");
            Console.WriteLine("Digite sua idade:");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 13 && age > 0)
            {
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("Você não tem idade suficiente para estudar nessa escola jovem, venha mais velho!");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                return;
            }
            if (age < 0) 
                {
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("Você não tem idade suficiente para estudar nessa escola jovem, venha mais velho!");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("====================================================");
            Console.WriteLine(username + " Como aluno do Instituto Nacional de Artes e Formação Atlas");
            Console.WriteLine("Você precisa vencer um aluno do mesmo ano para passar de ano.");
            Console.WriteLine("Mas pode ficar tranquilo não é tão difícil assim.");
            Console.WriteLine("Você praticava nas aulas não se lembra? Então vamos lá");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("====================================================");
            Console.WriteLine("Qual era mesmo qual você praticava? Muay Thai, Jiu-Jitsu ou KickBox?");
            Console.WriteLine("1: Muay Thai");
            Console.WriteLine("2: Jiu-Jitsu");
            Console.WriteLine("3: KickBox");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            int num = Convert.ToInt32(Console.ReadLine());
            

            while (num < 1 || num > 3)
            {
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("Opção inválida. Por favor, escolha novamente.");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("====================================================");
                Console.WriteLine();
            }

                if (num == 1)
            {
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine(username + ", Muay Thai é bem um estilo bem estável, você terá 7 de vida e 8 de stamina");
                Console.WriteLine("Você é bem equilibrado por causa disso em momentos de resitência você e o melhor");
                Console.WriteLine("Você pode gastar 1 de energia e caso o embate tenha sido um empate você vence o round.");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();

                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("Suas Técnicas são: ");
                Console.WriteLine("Cotovelada, Chute médio e Direto");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("Tome cuidado enquanto luta você se cansa, mas quanto maior o esforço maior a força.");
                Console.WriteLine("Cotovelada: Gasta 1 de stâmina, Chute médio: gastar 1 de stâmina e o Direto 2 de Stâmina");
                Console.WriteLine("Cotovelada causa: 1 de dano, Chute médio causa 1 de dano e o Direto causa 2 de dano");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("Mas lembre-se não é porque o golpe é poderoso que sempre deve usa-lo");
                Console.WriteLine("Todo estilo de luta tem suas maneiras de evitar os golpes e contra-atacar");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                life = 7;
                stamina = 8;
            }
            else if (num == 2)
            {
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine(username + ", Jiu-Jitsu é um estilo de luta muito eficaz, você terá 9 de vida e 7 de stamina");
                Console.WriteLine("Você sabe bem que se imobilizar o oponente você pode ganhar a luta");
                Console.WriteLine("Você pode gastar 2 de Stâmina para agarrar o alvo fazendo com que ele não possa utilizar a sua habilidade especial.");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("Suas Técnicas são: ");
                Console.WriteLine("Montada, O-soto-gari e Guarda ");
                Console.WriteLine("Montada: Gasta 1 de stâmina, O-soto-gari: gastar 1 de stâmina e a Guarda 1 de Stâmina");
                Console.WriteLine("Montada causa: 1 de dano, O-soto-gari causa 1 de dano e a Guarda causa 1 de dano");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("Mas lembre-se você é sempre quem menos se desgasta, seu esforço nunca é alto");
                Console.WriteLine("Todo estilo de luta tem suas maneiras de evitar os golpes e contra-atacar");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                life = 9;
                stamina = 7;
            }
            else if (num == 3)
            {
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine(username + ", KickBox é um estilo de luta muito agressivo, você terá 6 de vida e 9 de stamina");
                Console.WriteLine("Seu lema é que a melhor defesa é o ataque");
                Console.WriteLine("Você pode gastar 2 Stâmina invés de atacar e se preparar e caso o utilize seu especial você o contra-ataca não sendo afetado.");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("Suas Técnicas são: ");
                Console.WriteLine("Cruzado, chute baixo e esquiva");
                Console.WriteLine("Cruzado: Gasta 2 de stâmina, chute baixo: gastar 1 de stâmina e a esquiva 1 de Stâmina");
                Console.WriteLine("Cruzado causa: 2 de dano, chute baixo causa 1 de dano e a esquiva causa 1 de dano");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("Mas lembre-se não é porque o golpe é poderoso que sempre deve usa-lo");
                Console.WriteLine("Todo estilo de luta tem suas maneiras de evitar os golpes e contra-atacar");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                life = 6;
                stamina = 9;
            }
            else
            {
                Console.WriteLine("Você não digitou um número válido, tente novamente");
            }
            Console.WriteLine();
            Console.WriteLine("====================================================");
            Console.WriteLine("Agora escolha um dos seus colegas para lutar contra você.");
            Console.WriteLine("1: Diego.");
            Console.WriteLine("2: Lucas.");
            Console.WriteLine("3: Matheus.");
            Console.WriteLine("4: Pedro.");
            Console.WriteLine("5: Rafael.");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            string username2 = Console.ReadLine();
            while (username2 != "Diego" && username2 != "Lucas" && username2 != "Matheus" && username2 != "Pedro" && username2 != "Rafael") 
            {
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("Nome inválido, tente novamente:");
                username2 = Console.ReadLine();
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

            if (username2 == "Diego")
            {
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("Você escolheu " + username2);
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else if (username2 == "Lucas")
            {
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("Você escolheu " + username2);
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else if (username2 == "Matheus")
            {
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("Você escolheu " + username2);
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else if (username2 == "Pedro")
            {
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("Você escolheu " + username2);
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else if (username2 == "Rafael")
            {
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("Você escolheu " + username2);
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("Você não digitou um nome valído, tente novamente");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            int numero = sorteador.Next(1, 4);

            if (numero == 1)
            {
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("O aluno " + username2 + " luta o estilo de luta Muay Thai");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                life2 = 7;
                stamina2 = 8;
            }
            else if (numero == 2)
            {
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("O aluno " + username2 + " luta o estilo de luta Jiu-Jitsu");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                life2 = 9;
                stamina2 = 7;
            }
            else if (numero == 3)
            {
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("O aluno " + username2 + " luta o estilo de luta KickBox");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                life2 = 6;
                stamina2 = 9;
            }
            Console.WriteLine();
            Console.WriteLine("====================================================");
            Console.WriteLine("Agora vamos começar a luta, você tem " + life + " de vida e " + stamina + " de stâmina");
            Console.WriteLine("Escolha sua ação na luta: ");
            Console.WriteLine("====================================================");
            Console.WriteLine();

            while (life > 0 && life2 > 0)
            {
                bool jogadorAtacou = true;
                bool botAtacou = true;
                especial = false;

                if (stamina <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Você está sem stamina!");
                    Console.WriteLine("Você gastou sua ação para recuperar stamina.");
                    Console.WriteLine("====================================================");
                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();

                    stamina = 3;

                    jogadorAtacou = false;
                }
                else
                {
                    Console.WriteLine("Escolha sua ação:");

                    if (num == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("====================================================");
                        Console.WriteLine("Suas Técnicas são:");
                        Console.WriteLine("Cotovelada, Chute médio e Direto");
                        Console.WriteLine("====================================================");
                        Console.WriteLine();

                        string golpe = Console.ReadLine();

                        while (golpe != "Cotovelada" &&
                               golpe != "Chute médio" &&
                               golpe != "Direto")
                        {
                            Console.WriteLine();
                            Console.WriteLine("====================================================");
                            Console.WriteLine("Técnica inválida, tente novamente:");
                            golpe = Console.ReadLine();
                            Console.WriteLine("====================================================");
                            Console.WriteLine();
                        }

                        if (golpe == "Cotovelada")
                        {
                            tipoGolpe = 1;
                            gasto = 1;
                        }
                        else if (golpe == "Chute médio")
                        {
                            tipoGolpe = 2;
                            gasto = 1;
                        }
                        else
                        {
                            tipoGolpe = 3;
                            gasto = 2;
                        }
                    }

                    else if (num == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("====================================================");
                        Console.WriteLine("Suas Técnicas são:");
                        Console.WriteLine("Montada, O-soto-gari e Guarda");
                        Console.WriteLine("====================================================");
                        Console.WriteLine();

                        string golpe = Console.ReadLine();

                        while (golpe != "Montada" &&
                               golpe != "O-soto-gari" &&
                               golpe != "Guarda")
                        {
                            Console.WriteLine();
                            Console.WriteLine("====================================================");
                            Console.WriteLine("Técnica inválida, tente novamente:");
                            golpe = Console.ReadLine();
                            Console.WriteLine("====================================================");
                            Console.WriteLine();
                        }

                        if (golpe == "Montada")
                        {
                            tipoGolpe = 1;
                            gasto = 1;
                        }
                        else if (golpe == "O-soto-gari")
                        {
                            tipoGolpe = 2;
                            gasto = 1;
                        }
                        else
                        {
                            tipoGolpe = 3;
                            gasto = 1;
                        }
                    }

                    else if (num == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("====================================================");
                        Console.WriteLine("Suas Técnicas são:");
                        Console.WriteLine("Cruzado, chute baixo e esquiva");
                        Console.WriteLine("====================================================");
                        Console.WriteLine();

                        string golpe = Console.ReadLine();

                        while (golpe != "Cruzado" &&
                               golpe != "chute baixo" &&
                               golpe != "esquiva")
                        {
                            Console.WriteLine();
                            Console.WriteLine("====================================================");
                            Console.WriteLine("Técnica inválida, tente novamente:");
                            golpe = Console.ReadLine();
                            Console.WriteLine("====================================================");
                            Console.WriteLine();
                        }

                        if (golpe == "Cruzado")
                        {
                            tipoGolpe = 1;
                            gasto = 2;
                        }
                        else if (golpe == "chute baixo")
                        {
                            tipoGolpe = 2;
                            gasto = 1;
                        }
                        else
                        {
                            tipoGolpe = 3;
                            gasto = 1;
                        }
                    }



                    if (num == 2 && cooldownEspecial > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("====================================================");
                        Console.WriteLine("Sua habilidade especial está indisponível.");
                        Console.WriteLine("Rodadas restantes: " + cooldownEspecial);
                        Console.WriteLine("====================================================");
                        Console.WriteLine();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("====================================================");
                        Console.WriteLine("Você quer utilizar sua habilidade especial? (Sim/Não)");
                        string resposta = Console.ReadLine();
                        Console.WriteLine("====================================================");
                        Console.WriteLine();

                        if (resposta == "Sim")
                        {
                            if (stamina >= gasto + 1)
                            {
                                especial = true;
                                stamina = stamina - 1;

                                Console.WriteLine();
                                Console.WriteLine("====================================================");
                                Console.WriteLine("Você utilizou sua habilidade especial!");
                                Console.WriteLine("====================================================");
                                Console.WriteLine();
                                Console.WriteLine("Pressione qualquer tecla para continuar...");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("====================================================");
                                Console.WriteLine("Você não possui stamina suficiente!");
                                Console.WriteLine("====================================================");
                                Console.WriteLine();
                                Console.WriteLine("Pressione qualquer tecla para continuar...");
                                Console.ReadKey();
                            }
                        }
                    }

                    // Gasta stamina do golpe
                    stamina = stamina - gasto;
                }
                especial2 = false;

                if (stamina2 <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("====================================================");
                    Console.WriteLine("O oponente está sem stamina!");
                    Console.WriteLine("O oponente gastou sua ação para recuperar stamina.");
                    Console.WriteLine("====================================================");
                    Console.WriteLine();


                    stamina2 = 3;

                    botAtacou = false;
                }
                else
                {
                    int numero2 = sorteador2.Next(1, 4);

                    if (numero2 == 1)
                    {
                        tipoGolpe2 = 1;
                        gasto2 = 1;
                    }
                    else if (numero2 == 2)
                    {
                        tipoGolpe2 = 2;
                        gasto2 = 2;
                    }
                    else
                    {
                        tipoGolpe2 = 3;
                        gasto2 = 1;
                    }

                    // Bot decide se usa especial
                    int numeroEspecial = sorteador2.Next(1, 3);

                    if (numeroEspecial == 1)
                    {
                        especial2 = true;
                        stamina2 = stamina2 - 1;

                        Console.WriteLine();
                        Console.WriteLine("====================================================");
                        Console.WriteLine("O oponente utilizou sua habilidade especial!");
                        Console.WriteLine("====================================================");
                        Console.WriteLine();
                    }

                    stamina2 = stamina2 - gasto2;
                }
                if (jogadorAtacou && botAtacou)
                {
                    if (num == 3 && especial && especial2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("====================================================");
                        Console.WriteLine("Ambos utilizaram suas habilidades especiais!");
                        Console.WriteLine("Você venceu com sua habilidade especial!");
                        Console.WriteLine("====================================================");
                        Console.WriteLine();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();

                        life2 = life2 - 3;
                    }

                    else if (num == 3 && especial && !especial2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("====================================================");
                        Console.WriteLine("Você utilizou sua habilidade especial!");
                        Console.WriteLine("O oponente não utilizou a dele.");
                        Console.WriteLine("====================================================");
                        Console.WriteLine();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();

                        life = life - gasto2;
                    }
                    else if (num == 2)
                    {
                        if ((tipoGolpe == 1 && tipoGolpe2 == 2) ||
                            (tipoGolpe == 2 && tipoGolpe2 == 3) ||
                            (tipoGolpe == 3 && tipoGolpe2 == 1))
                        {
                            Console.WriteLine();
                            Console.WriteLine("====================================================");
                            Console.WriteLine("Você venceu a disputa!");
                            life2 = life2 - gasto;
                            Console.WriteLine("====================================================");
                            Console.WriteLine();
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                        }

                        else if ((tipoGolpe2 == 1 && tipoGolpe == 2) ||
                                 (tipoGolpe2 == 2 && tipoGolpe == 3) ||
                                 (tipoGolpe2 == 3 && tipoGolpe == 1))
                        {
                            Console.WriteLine();
                            Console.WriteLine("====================================================");
                            Console.WriteLine("Você perdeu a disputa!");
                            life = life - gasto2;
                            Console.WriteLine("====================================================");
                            Console.WriteLine();
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("====================================================");
                            Console.WriteLine("Empate!");
                            Console.WriteLine("====================================================");
                            Console.WriteLine();
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();

                            if (especial)
                            {
                                Console.WriteLine();
                                Console.WriteLine("====================================================");
                                Console.WriteLine("Sua habilidade especial foi utilizada!");
                                Console.WriteLine("====================================================");
                                Console.WriteLine();
                            }
                        }

                        if (especial)
                        {
                            cooldownEspecial = 2;
                        }
                    }
                    else if (num == 1)
                    {
                        if ((tipoGolpe == 1 && tipoGolpe2 == 2) ||
                            (tipoGolpe == 2 && tipoGolpe2 == 3) ||
                            (tipoGolpe == 3 && tipoGolpe2 == 1))
                        {
                            Console.WriteLine();
                            Console.WriteLine("====================================================");
                            Console.WriteLine("Você venceu a disputa!");
                            life2 = life2 - gasto;
                            Console.WriteLine("====================================================");
                            Console.WriteLine();
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                        }

                        else if ((tipoGolpe2 == 1 && tipoGolpe == 2) ||
                                 (tipoGolpe2 == 2 && tipoGolpe == 3) ||
                                 (tipoGolpe2 == 3 && tipoGolpe == 1))
                        {
                            Console.WriteLine();
                            Console.WriteLine("====================================================");
                            Console.WriteLine("Você perdeu a disputa!");
                            life = life - gasto2;
                            Console.WriteLine("====================================================");
                            Console.WriteLine();
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                        }

                        else
                        {
                            if (especial)
                            {
                                Console.WriteLine();
                                Console.WriteLine("====================================================");
                                Console.WriteLine("Sua habilidade especial transformou o empate em vitória!");
                                life2 = life2 - gasto;
                                Console.WriteLine("====================================================");
                                Console.WriteLine();
                                Console.WriteLine("Pressione qualquer tecla para continuar...");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("====================================================");
                                Console.WriteLine("Empate, ninguém sofreu dano.");
                                Console.WriteLine("====================================================");
                                Console.WriteLine();
                                Console.WriteLine("Pressione qualquer tecla para continuar...");
                                Console.ReadKey();
                            }
                        }
                    }
                }
                else if (!jogadorAtacou && !botAtacou)
                {
                    Console.WriteLine();
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Ambos recuperaram stamina.");
                    Console.WriteLine("====================================================");
                    Console.WriteLine();
                }

                else if (!jogadorAtacou && botAtacou)
                {
                    Console.WriteLine();
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Você recuperou stamina, mas o oponente atacou!");
                    Console.WriteLine("====================================================");
                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();

                    life = life - gasto2;
                }

                else if (jogadorAtacou && !botAtacou)
                {
                    Console.WriteLine();
                    Console.WriteLine("====================================================");
                    Console.WriteLine("O oponente recuperou stamina!");
                    Console.WriteLine("====================================================");
                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();

                    life2 = life2 - gasto;
                }
                if (cooldownEspecial > 0)
                {
                    cooldownEspecial--;
                }
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("----------- STATUS -----------");
                Console.WriteLine("Sua vida: " + life);
                Console.WriteLine("Sua stamina: " + stamina);
                Console.WriteLine("Vida do "+username2 + ": " + life2);
                Console.WriteLine("------------------------------");
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

            if (life <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("VOCÊ FOI DERROTADO!");
                Console.WriteLine("====================================================");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("====================================================");
                Console.WriteLine("PARABÉNS, VOCÊ VENCEU!");
                Console.WriteLine("Você passou de ano!");
                Console.WriteLine("====================================================");
                Console.WriteLine();
            }
        }
    }
}
 