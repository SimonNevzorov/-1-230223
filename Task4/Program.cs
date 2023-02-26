Console.WriteLine("Введите первое число :");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число :");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число :");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
// count =3
if (max < b) max = b;
if (max < c) max = c;
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(max);

