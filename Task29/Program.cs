// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

int lengthArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lengthArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(-100, 100);
    Console.Write(randomArray[i] + " ");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}