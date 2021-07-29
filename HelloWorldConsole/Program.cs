using System;

namespace HelloWorldConsole
{
    class Person
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
    class Program
    {
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


        }
    }
}
