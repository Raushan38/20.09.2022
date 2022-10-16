//  Задача 41: Пользователь вводит с клавиатуры 
// M чисел. Посчитайте, сколько чисел больше 0 
// ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine ("введите числа через пробел:");
string numbers = Console.ReadLine();
string [] newNumbers = new string [numbers.Length];
int z = 0;
for (int i = 0; i < newNumbers.Length; i++)
{
  if (numbers[i] == ' ')
  {
    z++;
  }
  else
  {
    newNumbers[z] = newNumbers[z]+$"{numbers[i]}";
  }
}
z++;
int [] resultNumbers = new int[z];
PrintArray (resultNumbers, newNumbers);
int sum = 0;
for (int i = 0; i < z; i++)
{
  if (resultNumbers[i]>0)
  {
    sum++;
  }
}
Console.WriteLine ("чисел больше 0: "+sum);

void PrintArray (int [] array, string [] String)
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(String[i]);
  Console.Write (array[i]+"  ");
  }
Console.WriteLine();
}