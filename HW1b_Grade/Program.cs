// HW1b Grade

// Your Name: Lucas Tenison
// Did you seek help ? If yes, specify the helper or web link here: My Dad

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask for firstname
            Console.WriteLine("Enter your first name:");
            //Create firstname variable
            string firstname = Console.ReadLine();

            //Ask for lastname
            Console.WriteLine("Enter your last name:");
            //Create lastname variable
            string lastname = Console.ReadLine();

            //Ask for student ID number
            Console.WriteLine("Enter your student ID number:");
            //Create student ID variable
            string studentID = Console.ReadLine();

            //Ask for assignment grades
            Console.WriteLine("What is your overall percentage for Assignments?");
            //Create assignemnts variable
            double assignments = Convert.ToDouble(Console.ReadLine());

            //Ask for Participation grade
            Console.WriteLine("What is your overall percentage for Participation?");
            //Create participation variable
            double participation = Convert.ToDouble(Console.ReadLine());

            //Ask for exam 1 percentage
            Console.WriteLine("What is your percentage for Exam 1?");
            //Create Exam 1 variable
            double exam1 = Convert.ToDouble(Console.ReadLine());

            //Ask for exam 2 percentage
            Console.WriteLine("What is you percentage for Exam 2?");
            //Create Exam 2 variable
            double exam2 = Convert.ToDouble(Console.ReadLine());

            //Ask for exam 3 percentage
            Console.WriteLine("Waht is your percentage for Exam 3?");
            //Create Exam 3 variable
            double exam3 = Convert.ToDouble(Console.ReadLine());

            //Create the constants for weights of each category
            const double assignment_weight = 0.20;
            const double participation_weight = 0.15;
            const double exam1_weight = 0.15;
            const double exam2_weight = 0.25;
            const double exam3_weight = 0.25;

            //Calculate the final grade
            double Final_Grade = (assignments * assignment_weight) + (participation * participation_weight) + (exam1 * exam1_weight) + (exam2 * exam2_weight) + (exam3 * exam3_weight);

            //Output the results
            Console.WriteLine("Student: " + firstname + " " + lastname);
            Console.WriteLine("Student ID: " + studentID);
            Console.WriteLine("Final Grade: " + Final_Grade.ToString("0.00") + "%");
            Console.ReadKey();
        }
    }
}
