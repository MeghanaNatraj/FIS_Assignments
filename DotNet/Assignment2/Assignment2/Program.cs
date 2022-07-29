using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Assign2
    {
        static void Main(string[] args)
        {
            Accounts a1 = new Accounts("25291010", "Meghana", "Savings", "Credit", 500);
            a1.Transaction("Credit", 500);
            double b = a1.GetBal();
            Console.WriteLine("Remaing balance: " + b);

            Students s1 = new Students(53, "Meghana", "5A", 5, "CSE");
            Console.WriteLine("The marks: ");
            int[] m = new int[] { 98, 70, 76, 98, 36, 87 };
            s1.DisplayResult(m);
            Console.ReadLine();
        }



    }

    public class Accounts
    {
        String AcNo;
        String CustomerName;
        String AccType;
        String TransType;
        double amount;
        double balance = 0;

        public double GetBal()
        {
            return balance;
        }
        public void Transaction(string TransType, int amt)
        {
            if (TransType == "Debit")
            {
                Console.WriteLine("Amount is debited: ");
                if (balance > amt)
                {
                    double b = debit(this.amount);
                    //this.balance -= 1;
                    //Console.WriteLine("Remaining balance: " + b);
                }

                else
                {
                    Console.WriteLine("Insufficient Balance");
                }
            }

            else if (TransType == "Credit")
            {
                Console.WriteLine("Amount is credited: ");
                double b = credit(this.amount);
                //this.balance += 1;
                //Console.WriteLine("Remaining balance: " + b);
            }
        }

        public double credit(double amt)
        {
            this.balance += amt;
            return balance;
        }

        public double debit(double amt)
        {
            this.balance -= amt;
            return balance;
        }

        public Accounts(string AcNo, string CusName, string AccType, string TrTy, double amt)
        {
            this.AcNo = AcNo;
            this.CustomerName = CusName;
            this.AccType = AccType;
            this.TransType = TrTy;
            this.amount = amt;

            Console.WriteLine("Account number: " + this.AcNo);
            Console.WriteLine("Cosumter Name: " + this.CustomerName);
            Console.WriteLine("Account Type: " + this.AccType);
        }

    }

    public class Students
    {
        int RollNo;
        string name;
        string Class;
        int sem;
        string branch;
        int[] marks = new int[5];

        public void DisplayResult(int[] m)
        {
            int tot = 0;
            for (int i = 0; i < m.Length; i++)
            {
                tot += m[i];
            }

            double avg = tot / m.Length;
            bool flag = true;
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] < 35 || avg < 50)
                {
                    flag = false;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        public Students(int RolNo, string name, string Clss, int sem, string branch)
        {
            this.RollNo = RolNo;
            this.name = name;
            this.Class = Clss;
            this.sem = sem;
            this.branch = branch;

            Console.WriteLine("Roll No: " + this.RollNo);
            Console.WriteLine("Roll No: " + this.name);
            Console.WriteLine("Roll No: " + this.Class);
            Console.WriteLine("Roll No: " + this.sem);
            Console.WriteLine("Roll No: " + this.branch);

        }
    }
}

