using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool accountCreated = false;
            BankAccount account = new BankAccount();

            bool displayMenu = true;
            
            while (displayMenu) {
                Console.WriteLine("*********************************");
                Console.WriteLine("*       Welcome to bank         *");
                Console.WriteLine("*                               *");
                Console.WriteLine("*   Press 1 to make a savings   *");
                Console.WriteLine("*     account                   *");
                Console.WriteLine("*                               *");
                Console.WriteLine("*   Press 2 to make a checkings *");
                Console.WriteLine("*     account                   *");
                Console.WriteLine("*                               *");
                Console.WriteLine("*   Press 3 to withdraw         *");
                Console.WriteLine("*   Press 4 to deposit          *");
                Console.WriteLine("*   Press 5 to check balance    *");
                Console.WriteLine("*   Press 6 to exit             *");
                Console.WriteLine("*                               *");
                Console.WriteLine("*   Please enter a number       *");
                Console.WriteLine("*    and press enter:           *");
                Console.WriteLine("*********************************");
                int input = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (input) {
                    case 1:

                        if (!accountCreated)
                        {
                            account = CreateAccount(true);
                            accountCreated = true;
                        }
                        else {
                            {
                                Console.WriteLine("*****************************************************");
                                Console.WriteLine("*   We could not do that because you already have   *");
                                Console.WriteLine("*   an acccount in our system                       *");
                                Console.WriteLine("*                                                   *");
                                Console.WriteLine("*   You will now be returned to our main menu       *");
                                Console.WriteLine("*****************************************************");
                                Task.Delay(1000).Wait();
                                Console.Clear();
                            }

                        }
                        break;
                    case 2:

                        if (!accountCreated){
                            account = CreateAccount(false);
                            accountCreated = true;
                        } else {
                            Console.WriteLine("*****************************************************");
                            Console.WriteLine("*   We could not do that because you already have   *");
                            Console.WriteLine("*   an acccount in our system                       *");
                            Console.WriteLine("*                                                   *");
                            Console.WriteLine("*   You will now be returned to our main menu       *");
                            Console.WriteLine("*****************************************************");
                            Task.Delay(1000).Wait();
                            Console.Clear();
                        }
                 
                        break;
                    case 3:
                        if (accountCreated)
                        {
                            if (account.getBalance() <= account.MinBalance) {
                                Console.WriteLine("You have no money in your account! Please deposit first.");
                                Task.Delay(3000).Wait();
                                break;
                            }
                            Console.WriteLine("*************************************************************");
                            Console.WriteLine("*                                                           *");
                            Console.WriteLine("*  Please enter the amount that you would like to withdraw  *");
                            Console.WriteLine("*                                                           *");
                            Console.WriteLine("*************************************************************");
                            float withdraw = (float)Double.Parse(Console.ReadLine());
                            Console.Clear();

                            if (withdraw > account.getBalance() - account.MinBalance){
                                Console.WriteLine("{0:C} was not available for withdrawl. withdrawing {1:C} instead!", withdraw, (account.getBalance() - account.MinBalance));
                            }
                            else{
                                Console.WriteLine("Withdrawing {0:C} from your account!", withdraw);
                                
                            }
                            account.withdraw(withdraw);
                            Task.Delay(3000).Wait();
                        }
                        else
                        {
                            Console.WriteLine("You must make an account first.");
                            Task.Delay(3000).Wait();
                        }
                        break;
                    case 4:
                        if (accountCreated)
                        {
                            Console.WriteLine("*************************************************************");
                            Console.WriteLine("*                                                           *");
                            Console.WriteLine("*  Please enter the amount that you would like to deposit   *");
                            Console.WriteLine("*                                                           *");
                            Console.WriteLine("*************************************************************");
                            float deposit = (float)Double.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("depositing {0:C} into your account!", deposit);
                            account.deposit(deposit);
                            Task.Delay(3000).Wait();
                        }
                        else {
                            Console.WriteLine("You must make an account first.");
                        }
                        break;
                    case 5:
                        if (accountCreated) {
                            Console.WriteLine("You have {0:C} in your account!", account.getBalance());
                            Task.Delay(3000).Wait();
                        }
                        else
                        {
                            Console.WriteLine("You must make an account first.");
                            Task.Delay(2000).Wait();
                        }
                        break;
                    case 6:
                        displayMenu = false;
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }

          
             
        }

        public static BankAccount CreateAccount(bool savings)
        {
            BankAccount ba;

            Console.WriteLine("*********************************");
            Console.WriteLine("*        Welcome to bank        *");
            Console.WriteLine("*                               *");
            Console.WriteLine("*  Your request is very         *");
            Console.WriteLine("*  important to us. Please      *");
            Console.WriteLine("*  wait while your account is   *");
            Console.WriteLine("*  created :)                   *");
            Console.WriteLine("*                               *");
            Console.WriteLine("*********************************");
            Task.Delay(5000).Wait();
            Console.Clear();
            if (savings)
            {
                ba = new SavingsAccount(0f);
            }
            else
            {
                ba = new CheckingAccount();
            }
            Console.WriteLine("Your account has been created succesfully! you will now return to the main menu.");
            Task.Delay(5000).Wait();
            Console.Clear();
            return ba;

        }
            

    }
}
