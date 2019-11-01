using System;

namespace GradeConverter {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Welcome to the Grade Converter");

            Console.WriteLine("Continue: ");
            Console.Read();
           
            String choice = "y";
            while (choice.Equals("y")) {
                Console.WriteLine("Enter Numerical Grade: ");
               Console.ReadLine();
                int numGrade;
                numGrade = Console.Read();
                char letterGrade;
                

                //use grade criteria to convert numGrade 
                //to letterGrade
                if (numGrade >= 88) ;
                    letterGrade = 'A';
                Console.WriteLine("Your grade is A");
                if (numGrade >= 80); 
                    letterGrade = 'B';
                Console.WriteLine("Your grade is B");
              if (numGrade >= 67)
                    letterGrade = 'C';
                Console.WriteLine("Your grade is C");
                if (numGrade >= 60)
                    letterGrade = 'D';
                Console.WriteLine("Your grade is D");
                if (numGrade<=59)
                    letterGrade = 'F';
                Console.WriteLine("You failed");



               
            }

                    Console.WriteLine("Continue?  ");



                }
            }
        }
    



        
            


