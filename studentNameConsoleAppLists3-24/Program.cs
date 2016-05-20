using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace studentNameConsoleAppLists3_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my student name program!");
            bool answer = true;     //need for do while loop
            List<string> StudentNameList = new List<string>() { "Stacey", "Niki", "Kyle", "Katherine", "Jackie", "Liam" };

            do
            {
                Console.WriteLine("\nMENU\n1--Add another student\n2--Clear out all students\n3--List all students\n4--Show count of students\n5--Save to a file\n6--Sort list alphabetically\n7--Exit");
                int userAction = 0;     //initializes the variable that holds the user's input, goes to default in switch case
                int.TryParse(Console.ReadLine(), out userAction);   //bool that handles if user did not enter an int

                switch (userAction)
                {
                    case 1:
                        AddStudent(StudentNameList);
                        break;
                    case 2:
                        ClearStudents(StudentNameList);
                        break;
                    case 3:
                        ListStudents(StudentNameList);
                        break;
                    case 4:
                        ShowCount(StudentNameList);
                        break;
                    case 5:
                        SaveToFile(StudentNameList);
                        break;
                    case 6:
                        SortList(StudentNameList);
                        break;
                    case 7:
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Try again.");
                        break;
                }

            }
            while (answer);
        }
        static void AddStudent(List<string> nameList)   //adds student names to the list
        {
            Console.WriteLine("Enter the student name: ");
            string name = Console.ReadLine();
            nameList.Add(name);
        }
        static void ClearStudents(List<string> nameList)    //clears the list
        {
            nameList.Clear();
        }
        static void ListStudents(List<string> nameList)     //prints list of students to console
        {
            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }
        }
        static void ShowCount(List<string> nameList)    //shows the number of students in the list
        {
            Console.WriteLine("There are {0} students in your list.", nameList.Count());
        }
        static void SaveToFile(List<string> nameList)   //saves the list of students to a file
        {
            StreamWriter writer = new StreamWriter("StudentNameList.txt");
            using(writer)
            {
                foreach (string name in nameList)
                {
                    writer.WriteLine(name);
                }
            }
        }
        static void SortList(List<string> nameList) //sorts the list alphabetically
        {
            nameList.Sort();
        }
        static void Exit()  //exits program
        {
            Console.WriteLine("Thank you for using my student name app.");
            Environment.Exit(0);
        }
    }
}
