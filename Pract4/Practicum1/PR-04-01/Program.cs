using System;
using System.Collections;

namespace PR_04_01
{
  class Program
  {
    static void Main(string[] args)
    {
      ArrayList myList = new ArrayList();
      myList.Add("Первый");
      myList.Add("Второй");
      myList.Add("Третий");
      myList.Add("Четвертый");
      foreach (string item in myList)
      {
        Console.WriteLine("Unsorted: {0}", item);
      }
      // Сортировка при помощи стандартного объекта сравнения 
      myList.Sort();
      foreach (string item in myList)
      {
        Console.WriteLine("   Sorted: {0}", item);
      }
    }

  }
}
