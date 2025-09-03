/* 
 Программа дл отримання назви дня тижня за номером дня тижня. Користувач вводить із клавіатури номер дня тижня (1-7)
 Необхідно вивести на екран назву дня тижня.
 Наприклад, якщо "1", на екрані напис "Понеділок", "2" — "Вівторок", тощо.
 */

class WeakDay
{
    static void Second() // - точка входу в програму, початок її виконання знаходиться в файлі Calculator.cs, змінити на Main() щоб запустити цю програму ( а в файлі Calculator зміни на іншу)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode; // - для коректного відображення українських символів в консолі

        Console.Write("Введіть номер дня тижня: ");
        byte dayNumber = byte.Parse(Console.ReadLine());
        
        string dayName;

        switch (dayNumber)
        {
            case 1:
                dayName = "Понеділок";
                break;
            case 2:
                dayName = "Вівторок";
                break;
            case 3:
                dayName = "Венсдей Аддамс";
                break;
            case 4:
                dayName = "Кровавий Четвер";
                break;
            case 5:
                dayName = "П'ятниця";
                break;
            case 6:
                dayName = "Субота";
                break;
            case 7:
                dayName = "Неділя";
                break;
            default:
                dayName = "Invalid day number";
                break;

        }
        Console.Write($"Ви вибрали - {dayName}\n");
    }
}
