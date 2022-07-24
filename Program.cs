using System;
using static System.Console;
Clear();

string[] array = { "Текст", ":)", "123", "сомf" };

WriteLine($"Заданный массив: [{PrintArray(array)}]");


string PrintArray(string[] arrayPrint)
{
   string result = String.Empty;
   for (int i = 0; i < arrayPrint.Length; i++)
   {
      if (i != arrayPrint.Length - 1) result += ($"\"{arrayPrint[i]}\", ");
      else result += ($"\"{arrayPrint[i]}\"");
   }
   return result;
}