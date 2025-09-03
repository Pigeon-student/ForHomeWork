/* 
���������� ������� ��� �i��� ����� �� ����������� ��: + - * ��� /
������� �� ������� ����������� 䳿 ���������� ��������� � �������.
��������������� ����������� SWITCH
*/

class Calculator
{
    static void Main() // - ����� ����� � ��������, ������� �� ���������
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode; // - ��� ���������� ����������� ���������� ������� � ������

        Console.Write("������ ����� �����: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("������ ����� �����: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("������ �� �� ����: ");
        char action = char.Parse(Console.ReadLine());
                
        switch (action)
        {
            case '+':
                Console.WriteLine($"��������� : {firstNumber + secondNumber}");
                break;
            case '-':
                Console.WriteLine($"��������� : {firstNumber - secondNumber}");
                break;
            case '*':
                Console.WriteLine($"��������� : {firstNumber * secondNumber}");
                break;
            case '/':

                //double result = (double)firstNumber / secondNumber; - ���� ����� ������� ��������� �������� ������ (�� ������ � ���� ��������)

                //double result = Math.Round(((double)firstNumber / secondNumber), 2); - ���� ����� ������� ��������� �������� ������ � ����������� �� 2� ����� ���� ���� (�� ������ � ���� ��������)

                //Console.WriteLine($"��������� : {result}"); - ���� ����������


                Console.WriteLine($"��������� : {firstNumber / secondNumber}"); // -���� ���������� ����� ������ (������ � ���� ��������)
                break;
            default:
                Console.WriteLine("����� ����������� ��������");
                break;

        }
    }
}