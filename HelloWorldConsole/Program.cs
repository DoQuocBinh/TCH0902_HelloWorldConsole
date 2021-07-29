using System;
using System.Collections.Generic;

namespace HelloWorldConsole
{
    
    partial class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public (string PName,int PAge) GetPersonInfo()
        {
            return (PName: Name,PAge: Age);
        }

        //default value a = K and b = false
        public void TestOptions(string a="K",bool b = false)
        {
            Console.WriteLine("The value of a is {0} and the value of b is {1}",a,b);
        }
    }
    public static class MyUtil
    {
        public static bool IsGoodEmail(this string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            else
                return false;
        }
        public static bool isMyyyyyyyyyyyOdd(this int number)
        {
            if (number % 2 == 1)
            {
                return true;
            }
            else
                return false;
        }
    }
    class Program
    {
        //default passing data by value. If you want to get the value out of the function=>get by reference
        static void GetDataFromInternet(ref int salary) //pass by reference
                {
                    salary = 25;//25 from database
                    Console.WriteLine("Salary is assigned with value: {0}", salary);
                }

        
        static void Main(string[] args)
        {
            //var d = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            //Console.WriteLine("Today is {0}", d);
            //Console.WriteLine("What is your name?");
            //var name = Console.ReadLine();
            //Console.WriteLine("What is your age?");
            //var age = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Hello {0} you were born in {1}", name, 2021 - age);

            var p = new Person { Name = "Licon", Age = 24 };// to replace creating a new constructure
            //var p2 = new Person { Name = "Phuong" };
            //var infor = p.GetPersonInfo();
            //Console.WriteLine("Name: {0} Age: {1}",infor.PName,infor.PAge);
            p.TestOptions(); // a = K , b = false
                             //p.TestOptions("Tom"); //a = Tom, b = false
                             //p.TestOptions("Jerry", true);//a = Jerry b = true

            //int mySalary = 0;
            //GetDataFromInternet(ref mySalary);
            //Console.WriteLine("My current salary: {0}",mySalary);

            //test property address in partial class
            var p3 = new Person { Name = "Jimmy", Age = 25, Address = "London" };

            //List<int> supports sort by default
            List<int> ds = new List<int> { 44,66,22,88,3467,777};
            ds.Sort();
            foreach (var item in ds)
            {
                Console.WriteLine(item);
            }

            //List<Person) doesn't support Sort by default
            List<Person> listPerson = new List<Person>
            {
                new Person{Name="Betty",Age=34},
                new Person{Name="Adam", Age=37},
                new Person {Name="Zidan",Age=36}
            };
            listPerson.Sort();
            foreach (var item in listPerson)
            {
                Console.WriteLine("Name : {0}, Age: {1}",item.Name,item.Age);
            }

            string email = "billgatesmicrosoft.com";
            if (email.IsGoodEmail())
            {
                Console.WriteLine("Good email");
            }
            else
            {
                Console.WriteLine("Not a good email");
            }
            int k = 46;
            Console.WriteLine(k.isMyyyyyyyyyyyOdd());

        }
    }
}
