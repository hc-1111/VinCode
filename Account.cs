using System;

namespace bank
{
    class Account
    {
        private String owner;
        private double balance;
        private String type;

       

        public Account(String owner, double balance, String type)
        {
            this.owner = owner;
            this.balance = balance;
            this.type = type;
        }

        public String getOwner()
        {
            return owner;
        }

        public void setOwner(String owner)
        {
            this.owner = owner;
        }

        public double getBalance()
        {
            return balance;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        public String getType()
        {
            return type;
        }

        public void setType(String type)
        {
            this.type = type;
        }

       
      public String toString()
        {
            return "Account{" +
                    "owner='" + owner + '\'' +
                    ", balance=" + balance +
                    ", type='" + type + '\'' +
                    '}';
        }

    }
}
