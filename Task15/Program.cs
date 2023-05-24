//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Clear();
Console.Write("Введи цифру, обозначающую день недели: ");
int numDay = Convert.ToInt32(Console.ReadLine());
CheckingTheDayOfTheWeek(numDay);
void CheckingTheDayOfTheWeek (int numDay)
{
  if (numDay == 6 || numDay == 7)
  {
  Console.WriteLine("Это выходной день");
  }
  else if (numDay < 1 || numDay > 7) {
    Console.WriteLine("Нет такого дня недели");
  }
  else Console.WriteLine("Это не выходной день");
}

