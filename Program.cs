using System;
using static System.Console;
Clear();

string[] array = { "Текст", ":)", "123", "сомf" };
int serchLength = 3;

WriteLine($"Заданный массив: [{PrintArray(array)}]");
string[] resultArray = SerchArrayElements(array, serchLength);
WriteLine($"Результат: [{PrintArray(resultArray)}]");


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

string[] SerchArrayElements(string[] arrayFirst, int size)
{
   // метод определения длинны массива с результатом
   int SerchSizeArray(string[] arraySerch, int size_1)
   {
      int count = 0;
      for (int i = 0; i < arraySerch.Length; i++)
      {
         string element = arraySerch[i];
         if (element.Length <= size) count++;
      }
      return count;
   }
   int k = 0;
   int sizeSecondArray = SerchSizeArray(arrayFirst, size);
   string[] arraySecond = new string[sizeSecondArray];
   for (int i = 0; i < arrayFirst.Length; i++)
   {
      string element = arrayFirst[i];
      if (element.Length <= size)
      {
         arraySecond[k] = arrayFirst[i];
         k++;
      }
   }
   return arraySecond;
}