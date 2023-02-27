Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
Console.WriteLine();
Console.WriteLine("Четные числа до введенного числа: ");

while (count <= num)
{
    if (count % 2 == 0)
    {
        Console.Write(" " + count);
    }
    count++;
}