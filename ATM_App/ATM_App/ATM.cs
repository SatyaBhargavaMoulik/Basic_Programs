using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;
namespace Practice
{
    interface IChange_Pin
    {
        void Change_Pin();
    }
    interface ICheck_Balance
    {
        void Check_Balance();
    }
    interface IDeposit_Amount
    {
        void Deposit_Amount();
    }
    interface IWithdraw_Cash
    {
        void Withdraw_Cash();
    }
    interface IMini_Statement
    {
        void Print_Mini_Statement();
    }

    internal class ATM : IChange_Pin, IMini_Statement, IWithdraw_Cash, IDeposit_Amount, ICheck_Balance
    {
        User_Account[] User_Details =
        {
            new User_Account()
            {
                Name="M S B Moulik Raj",Pin="2148",Aadhar_number="2556 9892 4351",Current_Balance=1500,Account_Number="1836100110083028"
            },
            new User_Account()
            {
                Name="G Samuel Babu",Pin="5626",Aadhar_number="4569 2569 7848",Current_Balance=4400,Account_Number="1836100110058962"
            },
            new User_Account()
            {
                Name="Y Ganesh Babu",Pin="2580",Aadhar_number="9874 5269 1248",Current_Balance=25000,Account_Number="1836100110074125"
            },
            new User_Account()
            {
                Name="M D S S Phanidhar",Pin="7845",Aadhar_number="8541 6587 3573",Current_Balance=2541,Account_Number="1836100110096582"
            }
        };
        string User_Name, Account_Number, Aadhar_number;
        int Current_Balance = 0;
        void Validate_Pin()
        {
            string pin;
            int flag = 0;
            Console.WriteLine("Enter Pin: ");
            pin = Console.ReadLine();
            foreach (User_Account user in User_Details)
            {
                if (user.Pin == pin)
                {
                    flag = 1;
                    User_Name = user.Name;
                    Account_Number = user.Account_Number;
                    Aadhar_number = user.Aadhar_number;
                    Current_Balance = user.Current_Balance;
                    Console.WriteLine("User Validated Successfully");
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Incorrect Pin");
                Console.WriteLine("User Not Found..Please Enter Correct Pin");
            }
        }
        public void Change_Pin()
        {
            Validate_Pin();
            if (Account_Number != null)
            {
                string Current_Pin, New_Pin;
                int flag = 0;
                Console.Write("Enter Current Pin : ");
                Current_Pin = Console.ReadLine();
                foreach (User_Account User in User_Details)
                {
                    if (User.Pin == Current_Pin)
                    {
                        flag = 1;
                        Console.Write("Enter new Pin : ");
                        New_Pin = Console.ReadLine();
                        User.Pin = New_Pin;
                        Console.WriteLine("Pin Changed Successfully");
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("Incorrect Pin...");
                    Console.WriteLine("Pin Change Process Terminated...");
                }

            }
        }
        public void Check_Balance()
        {
            Validate_Pin();
            if (Account_Number != null)
            {
                foreach (User_Account User in User_Details)
                {
                    if (User.Account_Number == Account_Number)
                    {
                        Console.WriteLine($"Current Balance : {User.Current_Balance}");
                    }
                }
            }
            else
            {
                Console.WriteLine("User Not Found");
            }
        }
        public void Deposit_Amount()
        {
            Validate_Pin();
            int flag = 0;
            if (Account_Number != null)
            {

                foreach (User_Account user in User_Details)
                {
                    if (Account_Number == user.Account_Number)
                    {
                        flag = 1;
                        int amount_to_deposit;
                        Console.Write("Enter Amount to deposit : ");
                        amount_to_deposit = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Current Balance is : {user.Current_Balance}");
                        user.Current_Balance += amount_to_deposit;
                        Console.WriteLine("Amount Deposited into Your Account");
                        Console.WriteLine($"Current Balance is : {user.Current_Balance}");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Process Terminated due to User Not Found");
            }

        }
        public void Withdraw_Cash()
        {
            Validate_Pin();
            int flag = 0;
            if (Account_Number != null)
            {
                foreach (User_Account user in User_Details)
                {
                    if (Account_Number == user.Account_Number)
                    {
                        flag = 1;
                        int amount_to_withdraw;
                        Console.Write("Enter Amount to Withdraw : ");
                        amount_to_withdraw = Convert.ToInt32(Console.ReadLine());
                        if (amount_to_withdraw > user.Current_Balance)
                        {
                            Console.WriteLine($"Current Balance is : {user.Current_Balance}");
                            Console.WriteLine("Insufficient Balance");
                            break;
                        }
                        else
                        {
                            user.Current_Balance -= amount_to_withdraw;
                            Console.WriteLine("Amount Withdraw Successful...");
                            Console.WriteLine("Please Collect Your Cash");
                            Console.WriteLine($"Current Balance is : {user.Current_Balance}");
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Process Terminated due to User Not Found");
            }
        }
        public void Print_Mini_Statement()
        {
            Validate_Pin();
            if (Account_Number != null)
            {
                foreach (User_Account user in User_Details)
                {
                    if (Account_Number == user.Account_Number)
                    {
                        Console.WriteLine($"Name : {user.Name}");
                        Console.WriteLine($"Account Number : {user.Account_Number}");
                        Console.WriteLine($"Aadhar Number : {user.Aadhar_number}");
                        Console.WriteLine($"Current Balance : {user.Current_Balance}");
                    }
                }
            }
            else
            {
                Console.WriteLine("-------");
            }
        }

    }
}
