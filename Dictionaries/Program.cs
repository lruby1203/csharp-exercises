using System;
using System.Collections.Generic;
using System.Linq;

namespace GradebookDict
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;
            int newId;
            
            Console.WriteLine("Enter your student's id number(or ENTER to finish):");
            do
            {
                Console.Write("id: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    newId = int.Parse(newStudent);
                    Console.Write("name: ");
                    string newName = Console.ReadLine();

                    students.Add(newId, newName);
                }
            }
            while (newStudent != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine("(" + student.Key + ") " + student.Value );
            }


            Console.ReadLine();
        }
    }
}
