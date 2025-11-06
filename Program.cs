using System;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Приключенческая новелла: Остров Судьбы";

            // приветствие игрока
            Console.WriteLine("Ты просыпаешься на берегу необитаемого острова...");
            Console.WriteLine("Перед тобой лес и пляж.");
            Console.WriteLine("1. Пойти в лес");
            Console.WriteLine("2. Осмотреть пляж");

            int step = 1; // текущий шаг
            int choice = GetChoice(); // выбор игрока

            while (true)
            {
                switch (step)
                {
                    case 1:
                        if (choice == 1)
                        {
                            Console.WriteLine("\nТы идёшь в лес. Слышишь странный шорох.");
                            Console.WriteLine("1. Проверить, кто там");
                            Console.WriteLine("2. Спрятаться за дерево");
                            step = 2;
                        }
                        else
                        {
                            Console.WriteLine("\nТы идёшь вдоль пляжа и находишь обломки лодки.");
                            Console.WriteLine("1. Осмотреть лодку");
                            Console.WriteLine("2. Вернуться к лесу");
                            step = 3;
                        }
                        choice = GetChoice();
                        break;

                    case 2:
                        if (choice == 1)
                        {
                            Console.WriteLine("\nТы находишь раненого попугая. Он говорит человеческим голосом!");
                            Console.WriteLine("1. Помочь ему");
                            Console.WriteLine("2. Уйти дальше");
                            step = 4;
                        }
                        else
                        {
                            Console.WriteLine("\nТы прячешься. Проходит время, темнеет.");
                            Console.WriteLine("1. Развести костёр");
                            Console.WriteLine("2. Идти в темноте");
                            step = 5;
                        }
                        choice = GetChoice();
                        break;

                    case 3:
                        if (choice == 1)
                        {
                            Console.WriteLine("\nВ лодке ты находишь карту и компас.");
                            Console.WriteLine("1. Взять находки");
                            Console.WriteLine("2. Не трогать — вдруг опасно");
                            step = 6;
                        }
                        else
                        {
                            Console.WriteLine("\nТы возвращаешься к лесу и слышишь рёв зверя!");
                            Console.WriteLine("1. Спрятаться в кустах");
                            Console.WriteLine("2. Взобраться на дерево");
                            step = 7;
                        }
                        choice = GetChoice();
                        break;

                    case 4:
                        if (choice == 1)
                        {
                            Console.WriteLine("\nПопугай благодарит и обещает показать путь к сокровищам.");
                            Console.WriteLine("1. Следовать за попугаем");
                            Console.WriteLine("2. Не верить и идти самому");
                            step = 8;
                        }
                        else
                        {
                            Console.WriteLine("\nТы уходишь. Через час теряешь направление.");
                            Console.WriteLine("1. Двигаться по солнцу");
                            Console.WriteLine("2. Идти наугад");
                            step = 9;
                        }
                        choice = GetChoice();
                        break;

                    case 5:
                        if (choice == 1)
                        {
                            Console.WriteLine("\nКостёр замечают спасатели!");
                            Console.WriteLine("1. Подать сигнал");
                            Console.WriteLine("2. Спрятаться");
                            step = 10;
                        }
                        else
                        {
                            // плохая концовка 1
                            Console.WriteLine("\nТы падаешь в овраг и теряешь сознание...");
                            End("Ты не смог выбраться. Конец приключения.", false);
                            return;
                        }
                        choice = GetChoice();
                        break;

                    case 6:
                        if (choice == 1)
                        {
                            Console.WriteLine("\nТеперь у тебя есть карта! Можно выбрать путь.");
                            Console.WriteLine("1. К центру острова");
                            Console.WriteLine("2. На север");
                            step = 11;
                        }
                        else
                        {
                            // плохая концовка 2
                            Console.WriteLine("\nБез карты ты заблудился в лесу...");
                            End("Ты блуждаешь по острову, пока не иссякли силы.", false);
                            return;
                        }
                        choice = GetChoice();
                        break;

                    case 7:
                        if (choice == 1)
                        {
                            Console.WriteLine("\nТы прячешься — мимо проходит стая волков.");
                            Console.WriteLine("1. Продолжить путь");
                            Console.WriteLine("2. Вернуться к берегу");
                            step = 12;
                        }
                        else
                        {
                            // плохая концовка 3
                            Console.WriteLine("\nВетка ломается, ты падаешь и теряешь сознание...");
                            End("Тебя больше никто не видел.", false);
                            return;
                        }
                        choice = GetChoice();
                        break;

                    case 8:
                        if (choice == 1)
                        {
                            // хорошая концовка 1
                            End("Попугай приводит тебя к сундуку с золотом! Ты разбогател и уплыл на лодке!", true);
                        }
                        else
                        {
                            // плохая концовка 4
                            End("Ты не послушал попугая и заблудился в джунглях. Конец.", false);
                        }
                        return;

                    case 10:
                        if (choice == 1)
                        {
                            // хорошая концовка 2
                            End("Спасатели замечают тебя и подбирают!", true);
                        }
                        else
                        {
                            // плохая концовка 5
                            End("Ты спрятался, думая, что это пираты... Но это был шанс спастись.", false);
                        }
                        return;

                    case 11:
                        if (choice == 1)
                        {
                            End("В центре острова ты находишь древний храм и артефакт, который исполняет желания.", true);
                        }
                        else
                        {
                            End("На севере ты находишь хижину и еду — выжил, но остался на острове.", false);
                        }
                        return;

                    case 12:
                        if (choice == 1)
                        {
                            End("Ты находишь лагерь спасателей — они забирают тебя домой!", true);
                        }
                        else
                        {
                            End("Ты возвращаешься к пляжу, но никого не находишь. Остров становится твоим домом.", false);
                        }
                        return;

                    default:
                        End("Ты слишком долго блуждал... Остров поглотил тебя.", false);
                        return;
                }
            }
        }

        // метод проверки корректности выбора (1 или 2)
        static int GetChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                Console.WriteLine("Введите 1 или 2:");
            }
            return choice;
        }

        // метод завершения игры
        static void End(string text, bool good)
        {
            Console.WriteLine("\n" + text);
            if (good)
                Console.WriteLine(" Хорошая концовка!");
            else
                Console.WriteLine(" Плохая концовка.");

        }
    }
}
