using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager {
    class MyConsole {

        public static string GetString(string prompt) {
            string str = "";
            while (true) {
                Console.Write(prompt);
                str = Console.ReadLine();
                break;
            }

            return str;
        }
        public static int GetInt(string prompt) {
            int i = 0;
            while (true) {
                Console.Write(prompt);
                try {
                    i = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception) {
                    Console.WriteLine("Error: Entry must be an int.");
                }
            }

            return i;
        }
        public static double GetDouble(string prompt) {
            double d = 0;
            Boolean success = false;
            while (!success) {
                Console.Write(prompt);
                /*try {
                    d = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception) {
                    Console.WriteLine("Error: Entry must be a decimal.");
                }*/
                success = double.TryParse(Console.ReadLine(), out d);
                if (!success) {
                    Console.WriteLine("Error:  Entry must be a decimal.");
                }
            }

            return d;
        }
    }
}