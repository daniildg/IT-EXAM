/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

int GetLength(string[] array, int size)
{
  int length = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= size) length++;
  }
  return length;
}

string[] FilterData(string[] array, int size)
{
  int newLength = GetLength(array, size) + 1;
  string[] newArray = new string[newLength];
  int count = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= size)
    {
      newArray[count] = array[i];
      count++;
    }
  }
  return newArray;
}

void PrintArray(string[] arr)
{
  Console.Write("[");
  foreach (string item in arr)
  {
    Console.Write($" {item}");
  }
  Console.Write("]");
}
Console.Write("Введите ваши данные через пробел -> ");
string initData = Console.ReadLine();
var dataArray = initData.Split(' ');
PrintArray(FilterData(dataArray, 3));