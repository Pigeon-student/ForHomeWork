/* 
Користувач вводить два цiлих числа та математичну дію: + - * або /
Залежно від введеної математичної дії виводиться результат в консоль.
Використовується конструкція SWITCH
*/

class Calculator
{
    static void Main() // - точка входу в програму, початок її виконання
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode; // - для коректного відображення українських символів в консолі

        Console.Write("Введіть перше число: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Введіть дію між ними: ");
        char action = char.Parse(Console.ReadLine());
                
        switch (action)
        {
            case '+':
                Console.WriteLine($"Результат : {firstNumber + secondNumber}");
                break;
            case '-':
                Console.WriteLine($"Результат : {firstNumber - secondNumber}");
                break;
            case '*':
                Console.WriteLine($"Результат : {firstNumber * secondNumber}");
                break;
            case '/':

                //double result = (double)firstNumber / secondNumber; - якщо треба вивести результат дробовим числом (не задано в умові завдання)

                //double result = Math.Round(((double)firstNumber / secondNumber), 2); - якщо треба вивести результат дробовим числом з округленням до 2х знаків після коми (не задано в умові завдання)

                //Console.WriteLine($"Результат : {result}"); - вивід результату


                Console.WriteLine($"Результат : {firstNumber / secondNumber}"); // -вивід результату цілим числом (задано в умові завдання)
                break;
            default:
                Console.WriteLine("Якесь ненормальне значення");
                break;

        }
    }
}