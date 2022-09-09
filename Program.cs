using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace textAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            GameTitle();
        }

        public static void GameTitle()
        {   Console.WriteLine("Добро Пожаловать в мою игру");
            Console.WriteLine("Нажми 'Enter' чтобы продолжить");
            Console.ReadLine();
            Console.Clear();
            First();

        }
    
                public static void First()
                
                {   string choice;
                    Console.WriteLine("Ты просыпаешься в классе с сердитым мистером Штормом стоящим над тобой");
                    Console.WriteLine("Что ты делаешь?");
                    Console.WriteLine("1.Ударь его");
                    Console.WriteLine("2.Заплачь");
                    Console.WriteLine("3.выбеги из кабинета");
                    Console.Write("Choice: ");
                    choice = Console.ReadLine().ToLower();
                    Console.Clear();
                    switch (choice)
                    {
                        case "1":

                            {
                                Console.WriteLine("Твой кулак впечатан в лицо мистера Шторма");
                                Console.WriteLine("Все остальные ученики в классе радуются тебе");
                                Console.WriteLine("Поднялся переполох и пришла разобраться мисис Шторм");
                                Console.WriteLine("Когда она увидела что её муж плачет на полу она начала стрелять своим лазерным взглядом в тебя");
                                Console.WriteLine("Нажми 'Enter' Чтобы продолжить");
                                Console.ReadLine();
                                GameOver();
                                break;
                            }

                        case "2":

                            {
                                Console.WriteLine("Щеки мистера Шторма становятся цвета помидора");
                                Console.WriteLine("Ты хочешь плакать? Сделай Это в коридоре!'Он кричит во всю глотку'.");
                                Console.WriteLine("Нажми 'Enter' чтобы продолжить!");
                                Console.ReadLine();
                                Second();
                                break;
                            }

                        case "3":

                            {
                                Console.WriteLine("Мистер Шторм орет на тебя.");
                                Console.WriteLine("БЫСТРО ВЕРНИСЬ.");
                                Console.WriteLine("Его ор слышит вся школа");
                                Console.WriteLine("Нажми 'Enter' чтобы продолжить!");
                                Console.ReadLine();
                                Second();
                                break;
                            }
                    }
                }
                public static void Second()
                {   Random rnd = new Random();
                    string[] secOptions = { "В коридоре ты видишь что менты обыскивают все шкафчики о которых одни беспокоются больше чем другие",
                                "следующее что ты видешь это то что тебя преследуют",
                                "В коридоре срабатывает пожарная сигнализация" };
                    int randomNumber = rnd.Next(0, 3);
                    string secText = secOptions[randomNumber];
                    string secChoice;
                    Console.WriteLine(secText);
                    Console.WriteLine("Ты пытаешься спрятаться в ванной? Да или Нет");
                    Console.Write("Выбор: ");
                    secChoice = Console.ReadLine().ToLower();

                    if (secChoice == "yes" || secChoice == "y")
                    {
                        Third();
                    }
                    else if (secChoice == "no" || secChoice == "n")
                    {   Console.WriteLine("Метеорит врезается в школу именно в этот момент, И убивает тебя мгновенно.");
                        Console.WriteLine("Нажмите 'Enter'чтобы продолжить!");
                        Console.ReadLine();
                        GameOver();
                    }
                }


                public static void Third()
                {   int age;
                    Console.WriteLine("Будет взрыв не хочешь спрятаться в ванной и  так ты врываешься в ванную а там все твои друзья и родственники");
                    Console.WriteLine("Они кричат сюрприз! и ты вспоминаешь что у тебя сегодня день рождения.");
                    Console.WriteLine("Сколько тебе лет?");
                    Console.WriteLine("Тебе:  (лет/год)");
                    int.TryParse(Console.ReadLine(), out age);
                    while (age < 100)
                    {   Console.WriteLine("Серьезно? ты выглядишь старше этого!");
                        Console.WriteLine("Сколько тебе лет на самом деле?");
                        Console.WriteLine("Тебе: (Лет/Год)");
                        int.TryParse(Console.ReadLine(), out age);
                    }
                    Console.WriteLine("Ух ты какой ты старый!");
                    youWin();
                }
               

                public static void GameOver()
                {   Console.Clear();
                    Console.WriteLine("На твоих похоронах рассказывают про твою храбрость потом они понимают на чьих похоронах они присутвсвуют и забирают свои слова обратно");
                    Console.WriteLine("В следующий раз повезет больше!");
                    Console.ReadLine();
                    Console.Clear();
                    GameTitle();
                }

                public static void YouWin()
                {   Console.Clear();
                    Console.WriteLine("Вечеринка по поводу твоего дня рождения имела большой успех, \nТор дал всем суперспособности \nВсе вы проживете ещё сто лет");
                    Console.WriteLine("Отличная работа!! Ты выиграл!!");
                    Console.WriteLine("Нажми 'Enter' чтобы начать заново\nКОНЕЦ");
                    Console.ReadLine();
                    Console.Clear();
                    GameTitle();
                } 
        
    }
}       