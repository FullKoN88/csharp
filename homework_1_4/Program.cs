/* PrintEvenNumbers, которая на вход принимает число (number), 
а на выходе выводит все чётные числа от 1 до number (включительно),
 разделеные знаком табуляции.
*/
Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

for(int count = 2; count <= number1; count += 2)
{
            Console.Write($"Четное число: {count}\t");
}

