﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradebookDict
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            string newStudent;
            StringBuilder MyStringBuilder = new StringBuilder();

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's grade
                    Console.Write("grade: ");
                    double newGrade = double.Parse(Console.ReadLine());

                    students.Add(newStudent, newGrade);
                }
            }
            while (newStudent != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<string, double> student in students)
            {
                MyStringBuilder.Append(student.Key + " (" + student.Value + ")\n");
            }
            Console.WriteLine(MyStringBuilder);
            double sum = students.Values.Sum();
            double avg = sum / students.Count;
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        }
    }
}
