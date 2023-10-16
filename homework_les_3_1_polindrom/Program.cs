/*
Напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.
14212 -> False
12821 -> True
234322 -> Число не пятизное
*/
/*
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000;
int n2 =
*/

System.Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number <= 99999 && number >= 10000);
{
    System.Console.WriteLine("Число не пятизначное");
}
int rev = 0;
while(number != 0)
{
    rev = rev * 10 + number % 10;
    number /= 10;
}
string str = rev.ToString();
Console.WriteLine($"{str[0]} {str[1]} {str[3]} {str[4]}");
if (str[0] == str[4] && str[1] == str[3])
{
    Console.WriteLine($"Число является палиндромом {str[0]} {str[1]} {str[3]} {str[4]}");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}
