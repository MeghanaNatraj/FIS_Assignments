using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Employee
    {
        int empId;
        string name;
        string department;
        string address;
        string city;
        string empType;
        double slary = 25000;
        public int EmpId
        {
            get
            {
                return empId;
            }
            set
            {
                empId = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public double Salary
        {
            get { return slary; }
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
        public string EmpType
        {
            get { return empType; }
            set { empType = value; }
        }
        public virtual void Accept()
        {
            Console.WriteLine("Base accept");
        }
        public virtual void Display()
        {
            Console.WriteLine("Base display");
        }
    }
    class PermanentEmployee : Employee
    {
        int leaves;
        double pf;
        public int Leaves
        {
            get { return leaves; }
            set { leaves = value; }
        }
        public double PF
        {
            get { return pf; }
            set { pf = value; }
        }

        public override double GetSalary()
        {

            return base.GetSalary() + pf;
        }
        public override void Accept()
        {

            Console.WriteLine("Enter employee Id");
            EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter employee Department");
            Department = Console.ReadLine();
            Console.WriteLine("Enter employee Address");
            Address = Console.ReadLine();
            Console.WriteLine("Enter employee City");
            City = Console.ReadLine();
            Console.WriteLine("Enter employee PF");
            pf = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter employee Leaves");
            leaves = int.Parse(Console.ReadLine());


        }
        public override void Display()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("  ");
            Console.WriteLine("Emp ID: " + EmpId);
            Console.WriteLine("name: " + Name);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Employee Type: " + EmpType);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("City: " + City);
            Console.WriteLine("PF: " + pf);
            Console.WriteLine("Leaves: " + leaves);
            Console.WriteLine("Total Salary: " + GetSalary());


        }

    }
    class ContractEmployee : Employee
    {
        double perk;
        public double Perk
        {
            get { return perk; }
            set { perk = value; }
        }

        public override double GetSalary()
        {
            return base.GetSalary() + perk;
        }

        public override void Accept()
        {
            Console.WriteLine("Enter employee Id");
            EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter employee Department");
            Department = Console.ReadLine();
            Console.WriteLine("Enter employee Address");
            Address = Console.ReadLine();
            Console.WriteLine("Enter employee City");
            City = Console.ReadLine();
            Console.WriteLine("Enter employee Perk");
            perk = Convert.ToDouble(Console.ReadLine());



        }
        public override void Display()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Employee Details");
            Console.WriteLine(" ");
            Console.WriteLine("Emp ID: " + EmpId);
            Console.WriteLine("name: " + Name);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Employee Type: " + EmpType);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("City: " + City);
            Console.WriteLine("Perk: " + perk);
            Console.WriteLine("Total Salary: " + GetSalary());
        }
    }
    class Assign3
    {
        static void Main(string[] args)
        {
            int ch;
            do
            {
            EmployeeType:
                Employee emp;
                Console.WriteLine("Type of Employee: \n1. Permanent Employee \n2. Contract Employee");
                ch = int.Parse(Console.ReadLine());
                if (ch == 1)
                {
                    emp = new PermanentEmployee();
                    emp.EmpType = "Permanent Emplyee";
                }
                else if (ch == 2)
                {
                    emp = new ContractEmployee();
                    emp.EmpType = "Contract Emplyee";
                }
                else
                {
                    Console.WriteLine("Wrong choice");
                    goto EmployeeType;
                }
            OperationType:
                Console.WriteLine("  ");
                Console.WriteLine("Choose: \n1. Insert employee details. \n2. Display Employee details \n3. Switch emp type \n4. Exit");
                ch = int.Parse(Console.ReadLine());
                Console.WriteLine("  -");
                switch (ch)
                {
                    case 1:
                        emp.Accept();
                        goto OperationType;

                    case 2:
                        emp.Display();
                        goto OperationType;
                    case 3:
                        goto EmployeeType;

                    case 4:
                        Console.WriteLine("Exit");
                        break;

                    default:

                        Console.WriteLine("Invalid");
                        goto OperationType;

                }
            } while (ch != 4);


            Undergraduate A = new Undergraduate();
            Graduate B = new Graduate();

            Console.WriteLine("1 . Undergraduate" + "\n" + "2 . Graduate");
            Console.WriteLine();

            int a1 = Convert.ToInt32(Console.ReadLine());

            if (a1 == 1)
            {
                Console.WriteLine("Enter the name of Student: ");
                A.name = Console.ReadLine();
                Console.WriteLine("Enter the studentId: ");
                A.studentID = Console.ReadLine();
                Console.WriteLine("Enter the grade of Student: ");
                A.grade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Result: " + A.Ispassed(A.grade));
            }
            else if (a1 == 2)
            {
                Console.WriteLine("Enter the Name of Student");
                B.name = Console.ReadLine();
                Console.WriteLine("Enter the studentId");
                B.studentID = Console.ReadLine();
                Console.WriteLine("Enter the Grade of Student");
                B.grade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Result of Student is " + B.Ispassed(B.grade));
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }

            Console.ReadLine();

        }

    }

    abstract class student
    {
        public string name;
        public string studentID;
        public double grade;

        public abstract bool Ispassed(double g);
    }

    class Undergraduate : student
    {
        public override bool Ispassed(double g)
        {
            if (g > 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Graduate : student
    {
        public override bool Ispassed(double g)
        {
            if (g > 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    

}
