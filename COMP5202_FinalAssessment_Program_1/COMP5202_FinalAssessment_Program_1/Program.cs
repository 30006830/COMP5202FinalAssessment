//Blake Jensen (Student ID: 30006830)
//Program purpose: Final Assessment for COMP5202 Question 1 Login system.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP5202_FinalAssessment_Program_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //code to present the console in white text
            Console.ForegroundColor = ConsoleColor.White;

            bool retrieveUsernameCheck = true;
            bool retrievePasswordCheck = true;

            //while loop to call validateUsername method
            while (retrieveUsernameCheck)
            {
                //introduction message
                Console.WriteLine("   ==================================================");
                Console.WriteLine("   ======Welcome to The Rotorua Thermal Holiday======");
                Console.WriteLine("   =================Park Staff Login=================");
                Console.WriteLine("   ==================================================\n");

                //prompts the user to press enter to continue to the next phase
                Console.WriteLine("   Press Enter to continue to the login system.");

                //prompts user to enter username that will be checked by the method
                Console.Write("   Please Enter the desired username: ");
                string userName = Console.ReadLine().Trim(); //.Trim() will not recognise spaces as characters therefore it will redirect to the error message.

                /*if statement that calls the validateUsername method for checking if
                  the username entered is valid or not, if it isn't there is an if   
                  statement with an error message*/
                if (validateUsername(userName) == 1)
                {
                    Console.WriteLine("   That Username is not valid, please enter a username with a minimum of 8 characters or more.\n");
                    Console.Write("   Press enter to try again. ");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("   Username set.");
                    break;
                }
            }

            //while loop to call validatePassword method
            while (retrievePasswordCheck)
            {
                //prompts user to enter a password twice
                Console.Write("   Enter a password (8 characters minimum): ");
                string passWord1 = Console.ReadLine().Trim();

                Console.Write("   Enter your password again: ");
                string passWord2 = Console.ReadLine().Trim();

                //calls the validatePassword method for all 3 if statements
                if (validatePassword(passWord1, passWord2) == 1)
                {
                    Console.WriteLine("   Password is below minimum requirements.");
                }
                
                else if (validatePassword(passWord1, passWord2) == 2)
                {
                    Console.WriteLine("   Username and Password has been accepted and set.");
                    break;
                }
                
                else if (validatePassword(passWord1, passWord2) == 3) 
                {
                    Console.WriteLine("   Password invalid, press enter to try again.");
                }  
            }
            Console.ReadLine();
        }

        //validateUsername method w/ if statements using an int type
        static int validateUsername(string userName)
        {
            if (userName.Length < 8) //checks if the name inputted is the required number
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        //validatePassword method w/ if statements: int type
        static int validatePassword(string passWord1, string passWord2)
        {
            if (passWord1.Length < 8)
            {
                return 1;
            }

            else if (passWord1 == passWord2)
            {
                return 2;
            }

            else if (passWord1 != passWord2)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
    }
}