// CheckIfEven, который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if ((number1 %  2) == 0)
{
Console.WriteLine("Число четное ");
}
else
{
    Console.WriteLine("Нет");
}