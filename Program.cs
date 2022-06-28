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
            SegundoAndar();
            TerceiroAndar();
            Encerramento();
            Console.ReadLine();

            static void PrimeiroAndar()
            {
                Goblin goblin = new Goblin("Goblin", 30, "Goblin", 12, 5, 100, 135);
                Knight kinght = new Knight("Arus", 42, "Knight", 15, 20, 749, 74);
                Ninja ninja = new Ninja("Wegde", 42, "Ninja", 25, 10, 574, 89);
                Wizard wizard = new Wizard("Jenica", 42, "White Wizard", 35, 10, 601, 482);
                Wizard blackWizard = new Wizard("Topapa", 42, "Black Wizard", 50, 10, 389, 641);

                System.Console.WriteLine("                        Em um lugar muito muito distante equipe de Century encontra uma torre e ao");
                System.Console.WriteLine("                                     entrar na torre encontram um terrivel " + goblin.Name);

                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

                Console.ReadLine();

                System.Console.WriteLine("                             " + goblin.Name + " diz: Muahahahahaha vocês jamais irão passar por esse torre \n");
                Console.ReadLine();

                System.Console.WriteLine("        Arus diz: E oque voce pretende fazer? nós somos a equipe Centurio jamais iremos perde para um orc qualquer");
                Console.ReadLine();

                System.Console.WriteLine("              " + goblin.Name + " diz:Então eu desafio a equipe Centurio para uma batalha vamos ver doque vocês são capazes\n");


                System.Console.WriteLine($"                                                Informaçoes de {goblin.Name}");
                System.Console.WriteLine("                             " + goblin.ToString());
                BatleSwitch();

                int damageGiven = 0;
                string attackCalc;
                int healtPoints = goblin.HealtPoints;

                while (healtPoints > 0)
                {
                    System.Console.WriteLine("                                              Digite [1] se deseja atacar com arus");
                    System.Console.WriteLine("                             " + kinght.ToString() + "\n");
                    System.Console.WriteLine("                                              Digite [2] se deseja atacar com Jenica");
                    System.Console.WriteLine("                             " + wizard.ToString() + "\n");
                    System.Console.WriteLine("                                              Digite [3] se deseja atacar com Wedge");
                    System.Console.WriteLine("                             " + ninja.ToString() + "\n");
                    System.Console.WriteLine("                                             Digite [4] se deseja atacar com Topapa");
                    System.Console.WriteLine("                            " + blackWizard.ToString() + "\n");
                    int heroSwitch = int.Parse(Console.ReadLine());

                    switch (heroSwitch)
                    {
                         case 1:
                            damageGiven = kinght.CalcularDano(kinght.AttackPoints, goblin.DefPoints);
                            attackCalc = kinght.Attack(damageGiven);
                            System.Console.WriteLine("                                          " + attackCalc);
                            System.Console.WriteLine("                                            -------------------------------------------------\n\n");
                            healtPoints = healtPoints - damageGiven;
                            break;
                        case 2:
                            damageGiven = wizard.CalcularDano(wizard.AttackPoints, goblin.DefPoints);
                            attackCalc = wizard.Attack(damageGiven);
                            System.Console.WriteLine("                                     " + attackCalc);
                            System.Console.WriteLine("                                       -------------------------------------------------------------\n\n");
                            healtPoints = healtPoints - damageGiven;
                            break;
                        case 3:
                            damageGiven = ninja.CalcularDano(ninja.AttackPoints, goblin.DefPoints);
                            attackCalc = ninja.Attack(damageGiven);
                            System.Console.WriteLine("                                          " + attackCalc);
                            System.Console.WriteLine("                                            -------------------------------------------------\n\n");
                            healtPoints = healtPoints - damageGiven;
                            break;
                        case 4:
                            damageGiven = blackWizard.CalcularDano(blackWizard.AttackPoints, goblin.DefPoints);
                            attackCalc = blackWizard.Attack(damageGiven);
                            System.Console.WriteLine("                                     " + attackCalc);
                            System.Console.WriteLine("                                       --------------------------------------------------------------\n\n");
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
                        System.Console.WriteLine("                                   ---------------------------------------------------------------------");
                        System.Console.WriteLine($"                                                    Agora o {goblin.Name} está com {healtPoints} de vida");
                        System.Console.WriteLine("                                  ----------------------------------------------------------------\n\n\n");
                    }
                }
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                System.Console.WriteLine("                                            PARABENS VOCE CONCLUIU O PRIMEIRO ANDAR");
                System.Console.WriteLine("                                         VOCÊ ACHA QUE É CAPAZ DE ENFRENTAR O PROXIMO NIVEL?");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.ReadLine();
            }
            static void SegundoAndar()
            {
                Orc orc = new Orc("Orc Master", 45, "Orc", 35, 45, 500, 250);
                Knight kinght = new Knight("Arus", 42, "Knight", 15, 20, 749, 74);
                Ninja ninja = new Ninja("Wegde", 42, "Ninja", 25, 10, 574, 89);
                Wizard wizard = new Wizard("Jenica", 42, "White Wizard", 35, 10, 601, 482);
                Wizard blackWizard = new Wizard("Topapa", 42, "Black Wizard", 50, 10, 389, 641);

                System.Console.WriteLine("                        A equipe centurio decide que ira desbravar toda aquela torre e ver oque a ");
                System.Console.WriteLine("                                               de tão assombroso ali! e la encontram o temido " + orc.Name);

                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

                Console.ReadLine();

                System.Console.WriteLine("                             " + orc.Name + " diz: Parece que voces passaram pelo pequeno goblin mas agora \n");
                System.Console.WriteLine("                                           as coisas irão ficar complicada para vocês muhahahahah");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------\n\n");
                Console.ReadLine();

                System.Console.WriteLine("                               Topapa diz: Escutamos a mesma coisa do seu amigo goblin hihihi");
                Console.ReadLine();


                System.Console.WriteLine($"                                                Informaçoes de {orc.Name}");
                System.Console.WriteLine("                         " + orc.ToString());
                BatleSwitch();

                int damageGiven = 0;
                string attackCalc;
                int healtPoints = orc.HealtPoints;

                while (healtPoints > 0)
                {
                    System.Console.WriteLine("                                              Digite [1] se deseja atacar com arus");
                    System.Console.WriteLine("                             " + kinght.ToString() + "\n");
                    System.Console.WriteLine("                                              Digite [2] se deseja atacar com Jenica");
                    System.Console.WriteLine("                             " + wizard.ToString() + "\n");
                    System.Console.WriteLine("                                              Digite [3] se deseja atacar com Wedge");
                    System.Console.WriteLine("                             " + ninja.ToString() + "\n");
                    System.Console.WriteLine("                                             Digite [4] se deseja atacar com Topapa");
                    System.Console.WriteLine("                            " + blackWizard.ToString() + "\n");
                    int heroSwitch = int.Parse(Console.ReadLine());

                    switch (heroSwitch)
                    {
                        case 1:
                            damageGiven = kinght.CalcularDano(kinght.AttackPoints, orc.DefPoints);
                            attackCalc = kinght.Attack(damageGiven);
                            System.Console.WriteLine("                                          " + attackCalc);
                            System.Console.WriteLine("                                            -------------------------------------------------\n\n");
                            healtPoints = healtPoints - damageGiven;
                            break;
                        case 2:
                            damageGiven = wizard.CalcularDano(wizard.AttackPoints, orc.DefPoints);
                            attackCalc = wizard.Attack(damageGiven);
                            System.Console.WriteLine("                                     " + attackCalc);
                            System.Console.WriteLine("                                       -------------------------------------------------------------\n\n");
                            healtPoints = healtPoints - damageGiven;
                            break;
                        case 3:
                            damageGiven = ninja.CalcularDano(ninja.AttackPoints, orc.DefPoints);
                            attackCalc = ninja.Attack(damageGiven);
                            System.Console.WriteLine("                                          " + attackCalc);
                            System.Console.WriteLine("                                            -------------------------------------------------\n\n");
                            healtPoints = healtPoints - damageGiven;
                            break;
                        case 4:
                            damageGiven = blackWizard.CalcularDano(blackWizard.AttackPoints, orc.DefPoints);
                            attackCalc = blackWizard.Attack(damageGiven);
                            System.Console.WriteLine("                                     " + attackCalc);
                            System.Console.WriteLine("                                       --------------------------------------------------------------\n\n");
                            healtPoints = healtPoints - damageGiven;
                            break;
                    }

                    if (healtPoints <= 0)
                    {
                        System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                        System.Console.WriteLine($"                                                   Você derrotou o {orc.Name}");
                        System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                    }
                    else
                    {
                       System.Console.WriteLine("                                   ---------------------------------------------------------------------");
                        System.Console.WriteLine($"                                                    Agora o {orc.Name} está com {healtPoints} de vida");
                        System.Console.WriteLine("                                  ----------------------------------------------------------------\n\n\n");
                    }
                }
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                System.Console.WriteLine("                                            PARABENS VOCE CONCLUIU O SEGUNDO ANDAR ");
                System.Console.WriteLine("                                         ESTA PREPARADO PARA DESCOBRIR O SEGREDO DESSA TORRE?");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.ReadLine();
            }
            static void TerceiroAndar()
            {
                Dragon dragon = new Dragon("Tiamat", 55, "Dragon", 150, 75, 1000, 500);
                Knight kinght = new Knight("Arus", 4, "Knight", 15, 20, 749, 74);
                Ninja ninja = new Ninja("Wegde", 42, "Ninja", 25, 10, 574, 89);
                Wizard wizard = new Wizard("Jenica", 42, "White Wizard", 35, 10, 601, 482);
                Wizard blackWizard = new Wizard("Topapa", 42, "Black Wizard", 50, 10, 389, 641);

                System.Console.WriteLine("                        Apos a vitoria super dificil contra o Orc Master a equipe centurio segue firme ");
                System.Console.WriteLine("                                           e sobem para o terceiro e ultimo andar!!!!!!");

                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.ReadLine();
                System.Console.WriteLine("                                        E se deparam com algo assustador !!!!!");
                Console.ReadLine();
                System.Console.WriteLine("                                             Arum diz: sera possivel?");
                Console.ReadLine();
                System.Console.WriteLine("                            Jenica diz: Disseram que eles tinham sido existintos a muito tempo?");
                Console.ReadLine();
                System.Console.WriteLine("                   Topapa diz: é acho que não restam duvidas esse terrivel monstro é de fato um Dragão");
                Console.ReadLine();
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                System.Console.WriteLine("                " + dragon.Name + " diz:muhahahamuahhahahahaha tenho que admitir até que vocês foram muito corajosos\n");
                System.Console.WriteLine("         de terem chegado até aqui mas agora é o fim da linha ninguem jamais consegiu sequer me fazer um arranhão!\n");
                Console.ReadLine();

                System.Console.WriteLine("                               Wedge diz: é pessoal agora a coisa ficou um pouco mais seria!!");
                Console.ReadLine();


                System.Console.WriteLine($"                                                   Informaçoes de {dragon.Name}");
                System.Console.WriteLine("                                " + dragon.ToString());
                BatleSwitch();

                int damageGiven = 0;
                string attackCalc;
                int healtPoints = dragon.HealtPoints;
                int countAtack = 0;


                while (healtPoints > 0)
                {
                    System.Console.WriteLine("                                              Digite [1] se deseja atacar com arus");
                    System.Console.WriteLine("                             " + kinght.ToString() + "\n");
                    System.Console.WriteLine("                                              Digite [2] se deseja atacar com Jenica");
                    System.Console.WriteLine("                             " + wizard.ToString() + "\n");
                    System.Console.WriteLine("                                              Digite [3] se deseja atacar com Wedge");
                    System.Console.WriteLine("                             " + ninja.ToString() + "\n");
                    System.Console.WriteLine("                                             Digite [4] se deseja atacar com Topapa");
                    System.Console.WriteLine("                            " + blackWizard.ToString() + "\n");
                    int heroSwitch = int.Parse(Console.ReadLine());


                    switch (heroSwitch)
                    {
                        case 1:
                            damageGiven = kinght.CalcularDano(kinght.AttackPoints, dragon.DefPoints);
                            attackCalc = kinght.Attack(damageGiven);
                            System.Console.WriteLine("                                          " + attackCalc);
                            System.Console.WriteLine("                                            -------------------------------------------------\n\n");
                            healtPoints = healtPoints - damageGiven;
                            break;
                        case 2:
                            damageGiven = wizard.CalcularDano(wizard.AttackPoints, dragon.DefPoints);
                            attackCalc = wizard.Attack(damageGiven);
                            System.Console.WriteLine("                                     " + attackCalc);
                            System.Console.WriteLine("                                       -------------------------------------------------------------\n\n");
                            healtPoints = healtPoints - damageGiven;
                            break;
                        case 3:
                            damageGiven = ninja.CalcularDano(ninja.AttackPoints, dragon.DefPoints);
                            attackCalc = ninja.Attack(damageGiven);
                            System.Console.WriteLine("                                          " + attackCalc);
                            System.Console.WriteLine("                                            -------------------------------------------------\n\n");
                            healtPoints = healtPoints - damageGiven;
                            break;
                        case 4:
                            damageGiven = blackWizard.CalcularDano(blackWizard.AttackPoints, dragon.DefPoints);
                            attackCalc = blackWizard.Attack(damageGiven);
                            System.Console.WriteLine("                                     " + attackCalc);
                            System.Console.WriteLine("                                       --------------------------------------------------------------\n\n");
                            healtPoints = healtPoints - damageGiven;
                            break;
                    }

                    countAtack++;
                    if (countAtack == 4 && healtPoints >= 0)
                    {
                        System.Console.WriteLine("                                -----------------------------------------------------------------------");
                        System.Console.WriteLine("                                          " + dragon.Attack(dragon.AttackPoints));
                        System.Console.WriteLine("                                -----------------------------------------------------------------------\n\n\n");
                        countAtack = 0;
                    }

                    if (healtPoints <= 0)
                    {
                        System.Console.WriteLine("                                -----------------------------------------------------------------------");
                        System.Console.WriteLine($"                                                    Você derrotou o {dragon.Name}");
                        System.Console.WriteLine("                                -----------------------------------------------------------------------\n");
                    }
                    else
                    {
                        System.Console.WriteLine("                                   ---------------------------------------------------------------------");
                        System.Console.WriteLine($"                                                    Agora o {dragon.Name} está com {healtPoints} de vida");
                        System.Console.WriteLine("                                  ----------------------------------------------------------------\n\n\n");
                    }
                }
                System.Console.WriteLine("                         E ASSIM A EQUIPE CENTURIO FINALMENTE PODE LEVAR A PAZ AO REINO DE ALABASTA!!!!!!!!!");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------\n");
                Console.ReadLine();
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                System.Console.WriteLine("                                              PARABENS VOCE CONCLUIU TODOS OS ANDARES ");
                System.Console.WriteLine("                                               SEM VOCÊ JAMAIS IRAMOS CONSEGUIR !!!!");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------\n\n\n");
                Console.ReadLine();

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
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------\n\n");
                Console.ReadLine();

            }

            static void BatleSwitch()
            {

                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------\n");
                System.Console.WriteLine("                                                Digite [y] se deseja batalhar");
                System.Console.WriteLine("                                         Digite [n] se deseja desistir da batalha");
                string batlleSwitch = Console.ReadLine();
                switch (batlleSwitch)
                {
                    case "y":
                        System.Console.WriteLine("                                          Equipe Centurio diz: Então vamos nessa!!!!\n\n");
                        break;

                    case "n":
                        System.Console.WriteLine("                       Acho que não podemos batalhar agora mas pode ter certeza que iremos retornar!");
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
                System.Console.WriteLine("                                           Obrigada por jogar Final Fantasy C# Edition");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------\n");
                System.Console.WriteLine("                                                    FINAL FANTASY C# EDITION");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------\n");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                System.Console.WriteLine("                                              Desenvolvido por: Matheus Rodrigues");
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            }

        }
    }
}
