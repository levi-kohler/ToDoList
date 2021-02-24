using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List!");
      menu();
    }
      public static void menu()
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Would you like to add an item or view your list? (add/view, or type 'exit' to quit)");
        Console.ForegroundColor = ConsoleColor.White;
        string userInput = Console.ReadLine();
        switch (userInput)
        {
          case "add":
            Add();
            break;

          case "view":
            View();
            break;

          case "exit":
            Console.WriteLine("Goodbye!");
            break;

          default:
            Console.WriteLine("Please input valid choice (add or view)");
            menu();
            break;
        }
      }

      public static void Add()
      {
        Console.WriteLine("Enter a description for the new Item on your To Do List:");
        string description = Console.ReadLine();
        Item newItem = new Item(description);
        menu();
      }

      public static void View()
      {
        List<Item> result = Item.GetAll();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + "To Do List:");
        for (int i = 0; i < result.Count; i++)
        {
          Console.WriteLine(result[i].Description.ToString());
        }
        Console.ForegroundColor = ConsoleColor.White;
        menu();
      }
  }
}