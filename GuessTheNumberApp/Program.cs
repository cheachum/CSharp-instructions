using System;

namespace GuessTheNumberApp {
    class Program {
   

        public class GuessTheNumberApp {

            public static void main(String[] args) {
                Console.WriteLine("Welcome to the Guess the Number Game");
                Console.WriteLine("====================================");
                

                String choice = "y";

                while (choice.Equals("y")) {
                    Console.WriteLine("I'm thinking of a number from 1 to 100.\n" +
                            "Try to guess it.\n");
                    int randNum = generateRandomNumber();
                    int guessCount = 0;
                    Console.WriteLine("nbr = " + randNum);
                    // prompt for a guess, compare to randNum, display output
                    // continue until guess == randNum
                    int guess = 0;
                    while (guess != randNum) {
                        guess = getWithinRange(Console.ReadLine()+"Enter number: ", 0, 101);
                        guessCount++;
                        int diff = guess - randNum;
                        String msg = "";
                        if (diff <= -10) {
                            msg = "Way too low!";
                        }
                        else if (diff < 0) {
                            msg = "Too low!";
                        }
                        else if (diff >= 10) {
                            msg = "Way too high!";
                        }
                        else if (diff > 0) {
                            msg = "Too high";
                        }
                        else {
                            // correct guess
                            msg = "You got it in " + guessCount + " tries.";
                            if (guessCount <= 3) {
                                msg += "Great work! You are a mathematical wizard.";
                            }
                            else if (guessCount <= 7) {
                                msg += "Not too bad! You've got some potential.";
                            }
                            else {
                                msg += "What took you so long? Maybe you should take some lessons.";
                            }
                        }
                        Console.WriteLine(msg);
                    }



                    choice = Console.Read()+ ("Try again? (y/n):  ");

                }

               
                Console.WriteLine("Bye");

            }

            private static int getWithinRange(string v1, int v2, int v3) {
                throw new NotImplementedException();
            }

            private static String getString(Console.Read()) {
                String s = "";
                Boolean isValid = false;
                // keep prompting until user enters y or n
                while (!isValid) {
                    Console.WriteLine();
                    s = Console.ReadLine();
                    // check for empty string
                    if (s.Equals("")) {
                        Console.WriteLine("Error... entry is required");
                        continue;
                    }
                    else if (s.Equals("y") || s.Equals("n")) {
                        isValid = true;
                    }
                    else {
                        Console.WriteLine("Error... only 'y' or 'n' is accepted.");
                        continue;
                    }
                }

                return s;
            }
            Random rnd = new Random();

            private static int generateRandomNumber() {
              
                int rnd = getIntWithinRange(1,12);  // creates a number between 1 and 12
                return rnd;
            }

            public static int getIntWithinRange(
                    int min, int max) {
                int i = 0;
                Boolean isValid = false;
                while (!isValid) {
                    i = Convert.ToInt32(Console.ReadLine()); 
                    if (i <= min) {
                        Console.WriteLine(
                                "Error! Number must be greater than " + min + ".");
                    }
                    else if (i >= max) {
                        Console.WriteLine(
                                "Error! Number must be less than " + max + ".");
                    }
                    else {
                        isValid = true;
                    }
                }
                return i;
            }

            public static int getInt() {
                int i = 0;
                Boolean isValid = false;
                while (!isValid) {
                    Console.Write(Console.Read());
                    if (i < 0) {
                        i = Convert.ToInt32(Console.ReadLine()); 
                        isValid = true;
                    }
                    else {
                        Console.WriteLine("Error! Invalid integer. Try again.");
                    }
                    Console.ReadLine();  // discard any other data entered on the line
                }
                return i;
            }


        }
    }
    }

