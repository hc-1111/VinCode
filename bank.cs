using System;
using System.Collections;
using System.Collections.Generic;

namespace bank
{
    class bank

    {
        private String name;
        private List<Account> Accounts;

      
        public bank(String name) { 
            this.name = name;
            Accounts = new List<Account>();
        }
        /*
         * Create Account
         */
        public void createNewAccount()
        {
            int type;
            String AccountType="";
            Console.WriteLine("please enter owner name :");
            String owner =  Console.ReadLine();
            Console.WriteLine("Please enter deposit balance");
            double balance = Convert.ToDouble(Console.ReadLine());
            bool check = false;
            do
            {
                Console.WriteLine("-----Select Account Type-----\n 1)Checking\n 2)Investment \n Selct >>");
                type = Convert.ToInt32(Console.ReadLine());
                if (type == 1)
                {
                    AccountType = "Checking";
                    check = true;
                }
                else if (type == 2)
                {
                    bool investmentCheck = false;
                    do
                    {
                        Console.WriteLine("-----Select Account Investment Type-----\n 1)Individual\n 2)Corporate\n Selct >>");
                        type = Convert.ToInt32(Console.ReadLine());
                        if(type ==1)
                        {
                            AccountType = "Individual";
                            investmentCheck = true;
                            check = true;

                        }
                        else if (type  ==2)
                        {
                            AccountType = "Corporate";
                            investmentCheck = true;
                            check = true;


                        }
                        else
                        {
                            Console.WriteLine("----------Invailid selection-------");
                        }
                    } while (investmentCheck == false);
                }
                else
                {
                    Console.WriteLine("---------Invalid Try Again--------");
                }
            } while (check == false);

            Account newAccount = new Account(owner, balance, AccountType);
            Accounts.Add(newAccount);
            Console.WriteLine("----------Account Created Successfully-----------");
            
    }

        /*
         * Deposit Amount
         */
        public bool deposit()
        {
            bool find = false;
            Console.WriteLine("please enter owner name to deposit :");
            String owner = Console.ReadLine();
            for(int x =0; x < Accounts.Count; x++)
            {
                if (Accounts[x].getOwner() == owner)
                {
                    Console.WriteLine("Please enter amount to deposit :");
                    double ammount = Convert.ToDouble(Console.ReadLine());
                    double total = Accounts[x].getBalance() + ammount;
                    Accounts[x].setBalance(total);
                    Console.WriteLine("------Deposit Successfully----------");
                    find = true;
                    break;
                }
            }

            if(find == true)
            {
                Console.WriteLine("----Invalid Owner name ----------");
            }

            return true;
        }

        /*
         * Withdraw Amount
         */
        public bool Withdraw()
        {
            bool find = false;
            Console.WriteLine("please enter owner name to withdraw :");
            String owner = Console.ReadLine();
            for (int x = 0; x < Accounts.Count; x++)
            {
                if (Accounts[x].getOwner() == owner)
                {
                    double amount;
                    do
                    {
                        Console.WriteLine("Please enter amount to withdraw :");
                         amount = Convert.ToDouble(Console.ReadLine());
                    } while (amount < 0);


                    while (Accounts[x].getBalance() < amount)
                    {
                        Console.WriteLine("Balance Exceed :) Try Again ");
                        amount = Convert.ToDouble(Console.ReadLine());

                    }

                    if (Accounts[x].getType() == "Individual" && amount > 500)
                    {
                        while(amount > 500)
                        {
                            Console.WriteLine("Amount Shold be less then or equals to 500");
                            Console.WriteLine("Please enter amount to withdraw :");
                             amount = Convert.ToDouble(Console.ReadLine());
                        }

                    }

                   

                    double total = Accounts[x].getBalance() - amount;
                    Accounts[x].setBalance(total);
                    Console.WriteLine("------Withdraw Successfully----------");
                    find = true;
                    break;
                }
            }

            if (find == true)
            {
                Console.WriteLine("----Invalid Owner name ----------");
            }

            return true;
        }


        /*
         * Withdraw Transfer
         */
        public bool transfer()
        {
            bool find = false;

            bool findReciver = false;
            Console.WriteLine("please enter sender name  :");
            String sender = Console.ReadLine();


            for (int x = 0; x < Accounts.Count; x++)
            {
                if (Accounts[x].getOwner() == sender)
                {
                    find = true;
                    double amount;
                    do
                    {
                        Console.WriteLine("Please enter amount to send :");
                        amount = Convert.ToDouble(Console.ReadLine());
                    } while (amount < 0);


                    while (Accounts[x].getBalance() < amount)
                    {
                        Console.WriteLine("Balance Exceed :) Try Again ");
                        amount = Convert.ToDouble(Console.ReadLine());

                    }

                    Console.WriteLine("please enter reciver name  :");
                    String reciver = Console.ReadLine();


                    for (int y = 0; y < Accounts.Count; y++)
                    {
                        if (Accounts[y].getOwner() == reciver)
                        {
                            Accounts[y].setBalance(Accounts[y].getBalance() + amount);
                            Accounts[x].setBalance(Accounts[x].getBalance() - amount);

                            findReciver = true;
                        }


                    }
                    if (findReciver == false)
                    {
                        Console.WriteLine("-------Reciver not found -------");
                    }
                    else
                    {
                        Console.WriteLine("------Transfered Successfully---------");
                    }
                }
            }
             if (find == true)
                {
                    Console.WriteLine("----Invalid sender name ----------");
                }
               

                return true;
            
        }
        /*
         * 
         * Dispaly All Accounts
         */

        public void displayAccounts()
        {
            Console.WriteLine("-------Registered Accounts------");
            for(int x =0; x<Accounts.Count; x++)
            {
                Console.WriteLine(Accounts[x].toString());
            }
            Console.WriteLine( "***************************");
        }
        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public List<Account> getAccounts()
        {
            return Accounts;
        }

        public void setAccounts(List<Account> accounts)
        {
            Accounts = accounts;
        }
    }
}
