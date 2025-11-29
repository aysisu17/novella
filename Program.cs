using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // отслеживание наличия предмета, влияющего на концовки
        bool hasOrb = false;

        Console.WriteLine("НОВЕЛЛА: ПЕЩЕРА ЗАБЫТЫХ ТАЙН");
        Console.WriteLine("Вы стоите перед входом в темную пещеру. Кажется, вы ищете артефакт.");

    // шаг 1: вход в пещеру
    Step1:
        Console.WriteLine("\nВы у входа. Холодный воздух манит внутрь.");
        Console.WriteLine("1. Зайти в пещеру.");
        Console.WriteLine("2. Отказаться от затеи и уйти.");

        string choice = Console.ReadLine();

        if (choice == "1") goto Step2;
        else if (choice == "2") goto Ending_Coward; // концовка 1
        else { Console.WriteLine("Неверный ввод."); goto Step1; }

    // шаг 2: главный зал
    Step2:
        Console.WriteLine("\nВнутри просторный зал. В центре тускло светится синий кристалл.");
        Console.WriteLine("1. Подойти к кристаллу.");
        Console.WriteLine("2. Пойти в левый туннель.");
        Console.WriteLine("3. Пойти в правый туннель.");

        choice = Console.ReadLine();

        if (choice == "1") goto Step3;
        else if (choice == "2") goto Step4;
        else if (choice == "3") goto Step5;
        else { Console.WriteLine("Неверный ввод."); goto Step2; }

    // шаг 3: кристалл
    Step3:
        Console.WriteLine("\nВы касаетесь кристалла. Он рассыпается, оставляя в руке Светящуюся Сферу.");
        hasOrb = true;
        Thread.Sleep(1500);
        goto Step2; // возвращаемся в главный зал

    // шаг 4: левый туннель (безопасный путь)
    Step4:
        Console.WriteLine("\nЛевый туннель выводит вас к подземному озеру.");
        goto Step6;

    // шаг 5: правый туннель (Опасность)
    Step5:
        Console.WriteLine("\nПравый туннель обваливается за спиной! Вы чудом пробегаете вперед.");
        goto Step6;

    // шаг 6: подземное озеро
    Step6:
        Console.WriteLine("\nВы у озера. В воде что-то блестит.");
        Console.WriteLine("1. Поискать что-то полезное в воде.");
        Console.WriteLine("2. Переплыть озеро к выходу.");

        choice = Console.ReadLine();

        if (choice == "1") goto Step7;
        else if (choice == "2") goto Step8;
        else { Console.WriteLine("Неверный ввод."); goto Step6; }

    // шаг 7: поиск в воде (Найти второй предмет)
    Step7:
        Console.WriteLine("\nВы находите старый, но крепкий меч на дне озера.");
        goto Step8;

    // шаг 8: другая сторона озера
    Step8:
        Console.WriteLine("\nВы перебрались через озеро. Перед вами две двери: деревянная и металлическая.");
        Console.WriteLine("1. Открыть деревянную дверь.");
        Console.WriteLine("2. Открыть металлическую дверь.");

        choice = Console.ReadLine();

        if (choice == "1") goto Step9;
        else if (choice == "2") goto Step10;
        else { Console.WriteLine("Неверный ввод."); goto Step8; }

    // шаг 9: деревянная дверь (Ловушка)
    Step9:
        Console.WriteLine("\nДеревянная дверь была ловушкой. Вы проваливаетесь в бездну.");
        goto Ending_Void; // концовка 2

    // шаг 10: металлическая дверь (Комната Стража)
    Step10:
        Console.WriteLine("\nМеталлическая дверь ведет в комнату, где спит древний страж.");
        Console.WriteLine("1. Попытаться тихо прокрасться мимо.");
        Console.WriteLine("2. Попытаться разбудить стража.");

        choice = Console.ReadLine();

        if (choice == "1") goto Step11;
        else if (choice == "2") goto Step12;
        else { Console.WriteLine("Неверный ввод."); goto Step10; }

    // шаг 11: прокрасться мимо
    Step11:
        Console.WriteLine("\nВам удается тихо проскользнуть мимо стража. Вы видите выход.");
        goto Step13;

    // шаг 12: разбудить стража
    Step12:
        Console.WriteLine("\nСтраж просыпается! Он слишком силен, чтобы сражаться.");
        goto Ending_Captured; // концовка 3

    // шаг 13: финальный зал
    Step13:
        Console.WriteLine("\nВы в последнем зале. Здесь лежит искомый артефакт, но он охраняется магическим барьером.");
        goto Step14;

    // шаг 14: барьер
    Step14:
        Console.WriteLine("\nБарьер требует энергии для отключения.");
        if (hasOrb)
        {
            Console.WriteLine("Вы используете Светящуюся Сферу! Она разрушает барьер.");
            goto Step15;
        }
        else
        {
            Console.WriteLine("У вас нет источника энергии. Выход закрыт, вы заперты здесь навсегда.");
            goto Ending_Trapped; // концовка 4
        }

    // шаг 15: Артефакт
    Step15:
        Console.WriteLine("\n[ШАГ 15] Вы забираете артефакт. Пещера начинает трястись, но вы успеваете убежать.");
        goto Ending_Victory; // концовка 5


    // концовки

    Ending_Coward:
        Console.WriteLine("\nТрус");
        Console.WriteLine("Вы вернулись домой. Приключение окончено, артефакт остался в пещере.");
        goto End;

    Ending_Void:
        Console.WriteLine("\nПадение");
        Console.WriteLine("Вы упали в бездну и погибли.");
        goto End;

    Ending_Captured:
        Console.WriteLine("\nПленник");
        Console.WriteLine("Страж пленил вас. Вы проведете остаток жизни в темнице пещеры.");
        goto End;

    Ending_Trapped:
        Console.WriteLine("\nВ западне");
        Console.WriteLine("Вы заперты в последнем зале, не в силах преодолеть барьер. Конец пути.");
        goto End;

    Ending_Victory:
        Console.WriteLine("\nПобеда");
        Console.WriteLine("Вы выбрались из пещеры с артефактом. Выполнено! Вы герой!");
        goto End;

    End:
        Console.WriteLine("\nИгра окончена.");
    }
}
