// Программа дл отримання назви дня тижня за номером дня тижня. Користувач вводить із клавіатури номер дня тижня (1-7)
// Необхідно вивести на екран назву дня тижня.
// Наприклад, якщо "1", на екрані напис "Понеділок", "2" — "Вівторок", тощо.


using System;

class WeakDay
{
    static void Main()
    {

        Console.Write("Введіть номер дня тижня: ");
        int dayNumber = int.Parse(Console.ReadLine());

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
        Console.Write($"Ви вибрали - {dayName}");
    }
}
