using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
	public class Program
	{
		public static void Main()
		{
			int number = 0;
			bool consoleLoop = true;
			while (consoleLoop)
			{
				Console.WriteLine("Welcome to the To Do List!");
				Console.WriteLine("Would you like to 'Add' and item to your list or 'View' your list? Or 'Q' to quit");
				string userInput1 = Console.ReadLine();
				if (userInput1.ToLower() == "add")
				{
					Console.WriteLine("Input the list item you would like displayed.");
					string userInput2 = Console.ReadLine();
					Item listItem = new Item(userInput2);
				}
				else if (userInput1.ToLower() == "view")
				{
					List<Item> ToDoList = Item.GetAll();
					foreach (Item toDo in ToDoList)
					{
						number += 1;
						Console.WriteLine(number + ". " + toDo.Description);
					}
					number = 0;
				}
				else if (userInput1.ToLower() == "q")
				{
					consoleLoop = false;
				}
				else
				{
					Console.WriteLine("Your input is invalid.");
				}
			}
			
		}
	}
}