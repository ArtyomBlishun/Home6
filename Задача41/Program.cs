// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите элементы: ");
string inputNum = Console.ReadLine();
int resoult = FillArray(inputNum);
Console.WriteLine($"M элементов > 0: {resoult}");

int FillArray(string num)
{
string[] arrayString = num.Split(" ");
int[] arrayInt = Array.ConvertAll(arrayString, int.Parse);
int count = 0;
 
    for (int i = 0; i < arrayInt.Length; i++)
    {
        if (arrayInt[i] > 0)
        {
            count++;
        }
    }

    return count;
}



