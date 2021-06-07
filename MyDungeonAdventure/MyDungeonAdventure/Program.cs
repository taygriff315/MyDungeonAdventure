using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDungeonAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hall of Shame";

            int score = 0;
            bool exit = false;

            Weapon sword = new Weapon(15, 25, "Scimitar", false, 10);
            Spell fire = new Spell(25, 30, 10, "Fire" );

            Hero hero = new Hero("Shaquille O'Neal", Race.Giant, sword, fire, 150, 150, 25, 10, 75, 30, 5, 5, "The Man of Steele");
            #region Title Screen
            System.Threading.Thread.Sleep(50);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                                Shaquille O'Neal's");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                ===================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("                                                || Hall Of Shame ||");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                ===================");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                              press enter to continue");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
           
            Console.WriteLine("An evil witch has cast a spell on Shaquille O'Neil");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            
            Console.WriteLine("Stripping him of all of his NBA Championship rings, she has sent him to a nightmare fighting against his most haunting fears.");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Collect all of your rings and then defeat the evil witch to save your legacy and remain one of the games all time greats.");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            #endregion
            do
            {
                Console.WriteLine();
                if (score == 4)
                {
                    Console.WriteLine("Nothing but darkness, followed by the hideous laughter of a wretched winch..");
                }
                else
                {


                    Console.WriteLine(GetRoom());
                }
                #region Monsters

                Zombie general = new Zombie("Zombie Aaron Carter", 50, 50, 10, 75, 10, 3, 20, "One time I beat Shaq in one-on-one.", @"
                                                                   /|x x|
                                                                  /\( - )
                                                          ___.-._/\/
                                                         /=`_'-'-'/  !!
                                                         |-{-_-_-}     !
                                                         (-{-_-_-}    !
                                                          \{_-_-_}   !
                                                           }-_-_-}
                                                           {-_|-_}
                                                           {-_|_-}
                                                           {_-|-_}
                                                           {_-|-_}  
                                                       ____%%@ @%%_______");




                Zombie barkley = new Zombie("Zombie Charles Barkley", 65, 65, 15, 70, 10, 5, 25, "The only difference between a good shot and a bad shot is if it goes in or not... RAAAUUUGHHH BLEEEEAGGHAAAAH!", @"                                                                   
                                                                    .....
                                                                   C C  /            
                                                                  /<   /             
                                                   ___ __________/_#__=o             
                                                  /(- /(\_\________   \              
                                                  \ ) \ )_      \o     \             
                                                  /|\ /|\       |'     |             
                                                                |     _|             
                                                                /o __\             
                                                               / '     |             
                                                              / /      |             
                                                             /_/\______|             
                                                            (_(    <              
                                                             \    \    \             
                                                              \    \    |            
                                                               \____\____\           
                                                               ____\_\__\_\          
                                                              /`   /`     o\          
                                                              |___ |_______|");

                Skeleton jordan = new Skeleton("Skeleton King Jordan", 80, 80, 15, 85, 15, 5, 20, "His royal air-ness. MJ doesn't go down without a fight.", @"  
                                                             .-.
                                                            (o.o)
                                                             |=|
                                                            __|__
                                                          //.=|=.\\
                                                         // .=|=. \\
                                                         \\ .=|=. //
                                                          \\(_=_)//                   
                                                           (:| |:)
                                                            || ||
                                                            () ()
                                                            || ||
                                                            || ||
                                                           ==' '==");

                #endregion
            
                Monster[] monsters = { general, barkley, jordan };
                Random rand = new Random();
                int randomNbr = rand.Next(monsters.Length);
                Monster monster = monsters[randomNbr];

                if (score ==4)
                {
                    Console.WriteLine("You've collected all the NBA Championship rings!!");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Now it's time to fight the witch and end all of this for good.");
                    System.Threading.Thread.Sleep(2500);

                    Spell darkMagic = new Spell(35, 35, 10, "Dark Magic");
                    monster = new Witch("Evil Witch", 100, 100, 20, 75, 10, 10, 20, "The evil witch that has stolen Shaqs legacy. She has a powerful magic attack. Be careful!", @"
                                                   /,
                                                  / \
                                              ___/___\__\ V /
                                                &(6_d)%   Y
                                                 /___\____|
                                                /) : (    |
                                                /     \   |
                                               '--V-V--'  |", darkMagic);
                    
                }

                Console.WriteLine("\n                              In this room: " + monster.Name);



                bool reload = false;
                do
                {
                    #region Game Menu
                    Console.WriteLine(monster.Image);

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("\n             HP <3 : {0} ", hero.Life);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write($"      Mana: {hero.Mana}");
                    Console.ResetColor();
                    Console.Write($"       :Please choose an action:     ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Potions: ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("H");
                    Console.ResetColor();
                    Console.Write($"[{hero.HealthPotions}]");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("  M");
                    Console.ResetColor();
                    Console.Write($"[{hero.ManaPotions}]");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write($"     Rings: {score} / 4\n\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("                           A) Attack   F) Fireball    R) Run Away   H) Health Potion   M) Mana Potion\n");
                    Console.WriteLine("\n                                        P) Player Info    I) Monster Info   X) Exit");
                    Console.ResetColor();
                    #endregion

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("Attack");

                            Combat.DoBattle(hero, monster);
                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n You have killed {0}!\n", monster.Name);
                                Console.ResetColor();

                                reload = true;
                                score++;
                            }

                            break;
                        case ConsoleKey.F:
                            Console.WriteLine("Shaq prepares to summon a massive fireball!!");
                            Combat.DoMagicAttack(hero, monster);
                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n You have killed {0}!\n", monster.Name);
                                Console.ResetColor();
                                
                                reload = true;
                                score++;
                            }
                            break;

                        case ConsoleKey.H:
                            if (hero.HealthPotions != 0)
                            {

                                Combat.UseHealthPotion(hero);
                                Combat.DoAttack(monster, hero);
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("You don't have any Health potions");
                            }

                            break;


                        case ConsoleKey.M:
                            if (hero.ManaPotions != 0)
                            {

                                Combat.UseManaPotion(hero);
                                Combat.DoAttack(monster, hero);
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("You don't have any Mana potions");
                            }
                            break;
                        case ConsoleKey.R:
                            if (score >= 4)
                            {
                                Console.WriteLine("You can't run away from the boss fight!!");
                            }
                            else
                            {
                                Console.WriteLine("Run Away");
                                exit = false;
                                reload = true;
                                Combat.DoAttack(monster, hero);
                                Console.WriteLine();
                            }
                         
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine(hero);
                            break;
                        case ConsoleKey.I:
                            Console.WriteLine(monster);
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("No one likes a quitter");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("That button doesn't do anything");
                            break;
                    }
                    if (hero.Life <= 0)
                    {
                        Console.WriteLine("You died.. Get your head in the game Shaq");
                        Console.ReadLine();
                        exit = true;
                    }

                    if (score >=5)
                    {
                        exit = true;
                    }

                } while (!exit && !reload);




              




            } while (!exit);

            if (score >= 5)
            {

                Console.WriteLine("Congrats!! You did it!!");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("You defeated the witch and saved the legacy of Shaquille O'Neil!!");
                System.Threading.Thread.Sleep(2500);
             
            }
            else
            {
                Console.WriteLine("GAME OVER.. You lose");
   
            }

            Console.WriteLine("Thanks for playing!!");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Designed by: Taylor Griffin");


        }

        #region Rooms
        private static string GetRoom()
        {
            string[] rooms =
            {@"                 Inside the room you see your highschool basketball jersey. As soon as you take a
                 step towards it, you hear something creep on you!",
            @"                  You walk into the room and its suddenly it's like you're on the floor of the
                  Staples Center. The lights go out. And then back on.",
            @"                   The room illuminates with a gold a shine. You see all of your NBA Championship
                   trophis sitting on table. At a closer look you see the jersery's of your teammates on the 
                   floor with skeleton bones inside of them.",

            };



            Random rand = new Random();

            int indexNbr = rand.Next(rooms.Length);
            string room = rooms[indexNbr];

            return room;

        }
            #endregion


    }
}





