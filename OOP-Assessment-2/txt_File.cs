using System.Collections.Generic;
using System.IO;

namespace OOP_Assessment_2
{
    class txt_File
    {
        //sets up a private list 
        private static List<txt_File> file_path = new List<txt_File>();

        //setting up constructors 
        private string Path_File { get; }
        private int Path_Number { get; }

        private txt_File(string path_file, int path_number)
        {
            Path_File = path_file;
            Path_Number = path_number;
        }

        //adds string path plus a path number to a list. 
        public static void Add_File_Path(string path_file, int path_number)
        {
            var addFile = new txt_File(path_file, path_number);
            file_path.Add(addFile);
        }

        //A foreach is used with the list it matches file_select to the Path_Number. It then reads the matching txt file 
        public static string[] Get_txt_File(int file_select)
        {
            foreach (var file in file_path)
            {
                if (file_select == file.Path_Number)                     //Matches user input to the path number
                {
                    string[] array = File.ReadAllLines(file.Path_File);  //Makes a string array by reading all lines in the file
                    return array;                                        //returns the array
                }
            }
            return null;
        }

        //returns the file name when called
        public static string Show_txt_File(int file_select)
        {
            foreach (var file in file_path)
            {
                if (file_select == file.Path_Number)            //Matches user input to the path number
                {
                    string file_name = file.Path_File;          //sets file_name to Path_File
                    return file_name;                           //returns the array
                }
            }
            return null;
        }

        //Reads in both files by using Get_txt_File method by passing on the file_select
        //when runs a series of tests which returns false if not the same and true if the same. 
        public static bool file_diff(int file_select1, int file_select2)
        {
            string[] first_file = Get_txt_File(file_select1);
            string[] second_file = Get_txt_File(file_select2);

            if (first_file.Length == second_file.Length)        //tests if first is the same length as the second file
            {
                for (int i = 0; i < first_file.Length; i++)     //runs a loop and tests each index element 
                {
                    if (first_file[i] != second_file[i])        //if element is not the same returns false
                    {
                        return false;
                    }
                }
                return true;                                    //returns true if all elements match
            }
            return false;                                       //returns false if length is not the same 
        }
    }
}