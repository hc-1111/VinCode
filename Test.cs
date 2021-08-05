using System;
using System.Collections.Generic;

namespace bank
{
    class Test
    {
       static bank mybank = new bank("USABank");
      
        static void Main(string[] args)
        {
            int select;

            do
            {
                Console.WriteLine("press\n1)to Craete a New Account\n2)Deposit\n3)WithDraw\n4)Transfer\n5)Dispaly All Accounts\n0)Exit \ninput >>");
                select = Convert.ToInt32(Console.ReadLine());
                if (select == 1)
                {
                    mybank.createNewAccount();
                }
                else if (select == 2)
                {
                    mybank.deposit();
                }
                else if (select == 3)
                {
                    mybank.Withdraw();
                }
                else if (select == 4)
                {
                    mybank.transfer();
                }
                else if (select == 5)
                {

                    mybank.displayAccounts();
                }
                else if (select == 0)
                {
                    Console.WriteLine("********************");   }
                else
                {
                    Console.WriteLine("--------Invalid Selection---------");
                }

            } while (select != 0);
        }
    }
}
