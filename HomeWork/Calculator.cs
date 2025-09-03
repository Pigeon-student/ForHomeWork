/*  (Як я щойно дізнався GitHub не підтримує українську мову, то для корректного відображення треба клонувати репозиторій на свій комп'ютер)
Êîðèñòóâà÷ ââîäèòü äâà öiëèõ ÷èñëà òà ìàòåìàòè÷íó ä³þ: + - * àáî /
Çàëåæíî â³ä ââåäåíî¿ ìàòåìàòè÷íî¿ ä³¿ âèâîäèòüñÿ ðåçóëüòàò â êîíñîëü.
Âèêîðèñòîâóºòüñÿ êîíñòðóêö³ÿ SWITCH
*/

class Calculator
{
    static void Main() // - òî÷êà âõîäó â ïðîãðàìó, ïî÷àòîê ¿¿ âèêîíàííÿ
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode; // - äëÿ êîðåêòíîãî â³äîáðàæåííÿ óêðà¿íñüêèõ ñèìâîë³â â êîíñîë³

        Console.Write("Ââåä³òü ïåðøå ÷èñëî: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Ââåä³òü äðóãå ÷èñëî: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Ââåä³òü ä³þ ì³æ íèìè: ");
        char action = char.Parse(Console.ReadLine());
                
        switch (action)
        {
            case '+':
                Console.WriteLine($"Ðåçóëüòàò : {firstNumber + secondNumber}");
                break;
            case '-':
                Console.WriteLine($"Ðåçóëüòàò : {firstNumber - secondNumber}");
                break;
            case '*':
                Console.WriteLine($"Ðåçóëüòàò : {firstNumber * secondNumber}");
                break;
            case '/':

                //double result = (double)firstNumber / secondNumber; - ÿêùî òðåáà âèâåñòè ðåçóëüòàò äðîáîâèì ÷èñëîì (íå çàäàíî â óìîâ³ çàâäàííÿ)

                //double result = Math.Round(((double)firstNumber / secondNumber), 2); - ÿêùî òðåáà âèâåñòè ðåçóëüòàò äðîáîâèì ÷èñëîì ç îêðóãëåííÿì äî 2õ çíàê³â ï³ñëÿ êîìè (íå çàäàíî â óìîâ³ çàâäàííÿ)

                //Console.WriteLine($"Ðåçóëüòàò : {result}"); - âèâ³ä ðåçóëüòàòó


                Console.WriteLine($"Ðåçóëüòàò : {firstNumber / secondNumber}"); // -âèâ³ä ðåçóëüòàòó ö³ëèì ÷èñëîì (çàäàíî â óìîâ³ çàâäàííÿ)
                break;
            default:
                Console.WriteLine("ßêåñü íåíîðìàëüíå çíà÷åííÿ");
                break;

        }
    }
}
