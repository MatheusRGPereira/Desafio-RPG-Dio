using System;
using RPG_Dio.src.Entities;
using RPG_Dio.src.Entities.Oponents;

namespace RPG_Dio
{
    class Program
    {
        static void Main()
        {
            Abertura();
            PrimeiroAndar();
            Encerramento();
            Console.ReadLine();

            static void PrimeiroAndar()
            {
                Goblin goblin = new Goblin("Goblin", 40, "Goblin", 12, 5, 100, 135);
                Knight kinght = new Knight("Arus", 42, "Knight", 15, 20, 749, 74);
                Ninja ninja = new Ninja("Wegde", 42, "Ninja", 25, 10, 574, 89);
                Wizard wizard = new Wizard("Jenica", 42, "White Wizard", 35, 10, 601, 482);
                Wizard blackWizard = new Wizard("Topapa", 42, "Black Wizard", 50, 10, 389, 641);

                System.Console.WriteLine("                        Em um lugar muito muito distante equipe de Century encontra uma torre e ao");
                System.Console.WriteLine("                                     entrar na torre encontram um terrivel " + goblin.Name);

                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

                Console.ReadLine();

                System.Console.WriteLine("                             "+goblin.Name + " diz: Muahahahahaha vocês jamais irão passar por esse torre \n");
                Console.ReadLine();

                System.Console.WriteLine("        Arus diz: E oque voce pretende fazer? nós somos a equipe Centurio jamais iremos perde para um orc qualquer");
                Console.ReadLine();

                System.Console.WriteLine("              "+goblin.Name + " diz:Então eu desafio a equipe Centurio para uma batalha vamos ver doque vocês são capazes\n");


                System.Console.WriteLine($"                                          Informaçoes de {goblin.Name}");
                System.Console.WriteLine("                                   "+goblin.ToString());
                BatleSwitch();

                int damageGiven = 0;
                string attackCalc;
                int healtPoints = goblin.HealtPoints;

                while (healtPoints > 0)
                {
                    System.Console.WriteLine("                                              Digite [1] se deseja atacar com arus");
                    System.Console.WriteLine("                             "+kinght.ToString() + "\n");
                    System.Console.WriteLine("                                              Digite [2] se deseja atacar com Jenica");
                    System.Console.WriteLine("                             "+wizard.ToString() + "\n");
                    System.Console.WriteLine("                                              Digite [3] se deseja atacar com Wedge");
                    System.Console.WriteLine("                             "+ninja.ToString() + "\n");
                    System.Console.WriteLine("                                             Digite [4] se deseja atacar com Topapa");
                    System.Console.WriteLine("                            "+blackWizard.ToString() + "\n");
                    int heroSwitch = int.Parse(Console.ReadLine());

                    switch (heroSwitch)
                    {
                        case 1:
                            damageGiven = kinght.CalcularDano(kinght.AttackPoints, goblin.DefPoints);
                            attackCalc = kinght.Attack(damageGiven);
                            System.Console.WriteLine("                                     "+attackCalc);
                            healtPoints = healtPoints - damageGiven;
                            break;
                        case 2:
                            damageGiven = wizard.CalcularDano(wizard.AttackPoints, goblin.DefPoints);
                            attackCalc = wizard.Attack(damageGiven);
                            System.Console.WriteLine("                                 "+attackCalc);
                            healtPoints = healtPoints - damageGiven;
                            break;
                        case 3:
                            damageGiven = ninja.CalcularDano(ninja.AttackPoints, goblin.DefPoints);
                            attackCalc = ninja.Attack(damageGiven);
                            System.Console.WriteLine("                                     "+attackCalc);
                            healtPoints = healtPoints - damageGiven;
                            break;
                        case 4:
                            damageGiven = blackWizard.CalcularDano(blackWizard.AttackPoints, goblin.DefPoints);
                            attackCalc = blackWizard.Attack(damageGiven);
                            System.Console.WriteLine("                                  "+attackCalc);
                            healtPoints = healtPoints - damageGiven;
                            break;
                    }

                    if (healtPoints <= 0)
                    {
                        System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                        System.Console.WriteLine($"                                                   Você derrotou o {goblin.Name}");
                        System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                    }
                    else
                    {
                        System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                        System.Console.WriteLine($"                                            Agora o {goblin.Name} está com {healtPoints} de vida");
                        System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------\n");
                    }
                }
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                System.Console.WriteLine("                                            PARABENS VOCE CONCLUIU O PRIMEIRO ANDAR");
                System.Console.WriteLine("                                         VOCÊ ACHA QUE É CAPAZ DE ENFRENTAR O PROXIMO NIVEL?");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            }

            static void Abertura()
            {
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                System.Console.WriteLine("                                              FINAL FANTASY C# EDITION");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                System.Console.WriteLine("                                                Lista de comandos");
                System.Console.WriteLine("                                  [Enter] - Para passar para a proxima etapa");
                System.Console.WriteLine("                               [y] - Para decidir se ira batalhar com sua equipe");
                System.Console.WriteLine("                                 [n] - Para decidir não batalhar com sua equipe");
                System.Console.WriteLine("                                          [1] - Para atacar com Arus");
                System.Console.WriteLine("                                          [2] - Para atacar com Wedge");
                System.Console.WriteLine("                                          [3] - Para atacar com Jennica");
                System.Console.WriteLine("                                          [4] - Para atacar com Topapa");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.ReadLine();

            }

            static void BatleSwitch()
            {

                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------\n");
                System.Console.WriteLine("                                                  Digite [y] se deseja batalhar");
                System.Console.WriteLine("                                            Digite [n] se deseja desistir da batalha");
                string batlleSwitch = Console.ReadLine();
                switch (batlleSwitch)
                {
                    case "y":
                System.Console.WriteLine("                                                Equipe Centurio diz: Então vamos nessa!!!!\n\n");
                        break;

                    case "n":
                        System.Console.WriteLine("                        Acho que não podemos batalhar agora mas pode ter certeza que iremos retornar!");
                        Console.ReadLine();
                        Console.Clear();
                        Encerramento();
                        Console.ReadLine();
                        Console.Clear();
                        Main();
                        break;
                }
            }

            static void Encerramento()
            {
                System.Console.WriteLine("                                     Obrigada por jogar Final Fantasy C# Edition");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                System.Console.WriteLine("                                              FINAL FANTASY C# EDITION");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------\n");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                System.Console.WriteLine("                                          Desenvolvido por: Matheus Rodrigues");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------\n\n\n");

                System.Console.WriteLine("                                   Aperte enter para [enter] para tentar novamente");

            }

        }
    }
}
