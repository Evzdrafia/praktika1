﻿using System;

namespace _01y
{
  using System.Collections;
  class Program
  {
    static void Main(string[] args)
    {
      ArrayList myList = new ArrayList();
      myList.Add("First");
      myList.Add("Second");
      myList.Add("Third");
      myList.Add("7");
      myList.Add("bird");
      for(int i = 0; i < 5; i++) { 
      myList.Add("Ilusha");
      }
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
