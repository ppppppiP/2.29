// задание 2.21


Console.WriteLine("Введите число n  ");
int n = int.Parse(Console.ReadLine());

int x = n % 10 + n / 100 * 10 + n % 100 / 10 * 100;


Console.WriteLine(x);

