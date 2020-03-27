using System;

namespace OOP_Assessment_2
{
	//main menu asks the user for set inputs and stores them for later use.
	//Console.Clear is used throughout to give a cleaner view for the user.
	class Main_Menu
	{
		static void Main(string[] args)
		{
			//sets up each file path as a string 
			string path1 = @"file_a.txt";
			string path2 = @"file_b.txt";

			//adds the string path above with a corresponding number to a list 
			txt_File.Add_File_Path(path1, 1);
			txt_File.Add_File_Path(path2, 2);

			//Gets the user's input on which first file to use.
			//The error handling ensures only the correct input can be passed, any errors are shown with a error message.
			int file_select1 = -1;
			do
			{
				Console.WriteLine("Which first File to run " + "\n" + "1. file_a" + "\n" +
																	  "2. file_b");
				Console.WriteLine();
				Console.WriteLine("Type in the number then press enter");

				if (!int.TryParse(Console.ReadLine(), out file_select1))
				{
					Console.Clear();
					Console.WriteLine("Must enter 1 or 2");
					Console.WriteLine();
				}
				else
				{
					if (file_select1 < 1 || file_select1 > 2)
					{
						Console.Clear();
						Console.WriteLine("Must enter 1 or 2");
						Console.WriteLine();

					}
				}
			} while (file_select1 < 1 || file_select1 > 2);

			Console.Clear();

			//Gets the user's input on which second file to use.
			//The error handling ensures only the correct input can be passed, any errors are shown with a error message.
			int file_select2 = -1;
			do
			{
				Console.WriteLine("Which second File to run " + "\n" + "1. file_a" + "\n" +
																	   "2. file_b");
				Console.WriteLine();
				Console.WriteLine("Type in the number then press enter");

				if (!int.TryParse(Console.ReadLine(), out file_select2))
				{
					Console.Clear();
					Console.WriteLine("Must enter 1 or 2");
					Console.WriteLine();
				}
				else
				{
					if (file_select2 < 1 || file_select2 > 2)
					{
						Console.Clear();
						Console.WriteLine("Must enter 1 or 2");
						Console.WriteLine();
					}
				}
			} while (file_select2 < 1 || file_select2 > 2);

			Console.Clear();

			//calls the file_diff method in txt_File class and passes on the inputted values and returns true or false.			
			bool diff = txt_File.file_diff(file_select1, file_select2);

			if (diff == true)       //if diff is true print the following
			{
				Console.WriteLine("First file picked " + txt_File.Show_txt_File(file_select1) + " is the same as the second file picked " + txt_File.Show_txt_File(file_select2));
			}
			else                    //if diff is false print the following
			{
				Console.WriteLine("First file picked " + txt_File.Show_txt_File(file_select1) + " is not the same as the second file picked " + txt_File.Show_txt_File(file_select2));
			}

			Console.WriteLine();
			Console.WriteLine("Press Enter to Exit");
			Console.ReadLine();
		}
	}
}
