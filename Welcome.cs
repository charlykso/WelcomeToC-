using System;

namespace HelloWorld
{
    class Welcome
    {
        static void Main(string[] args)
        {
            //to print out our first text
            Console.Write("Hello, World! ");
            /*
            This and the above statement will print
            in thesame line
            */
            Console.Write("Welcome to C# class\n");

            // const int age;
            // age = 20;
            // double amount = 100.5;
            // char gender = 'M';
            // string name = "Ikenna";
            // bool isAtive = true;
            // age = age + 2;
            // Console.WriteLine(age);
            // Console.WriteLine(name);
            // Console.WriteLine(isAtive);
            // Console.WriteLine(gender);
            // Console.WriteLine(amount);

            // Console.Write("Enter username ");
            // string username = Console.ReadLine();

            // Console.WriteLine("Username is " + username);

            // Console.Write("How old are you? ");
            // int age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Your age is " +age);

            // Console.WriteLine($"Your username is {username} and you are {age} years old");

            // int x = 50;
            // int y = 100;
            // Console.WriteLine(Math.Max(x, y));
            // Console.WriteLine(Math.Min(x, y));
            // Console.WriteLine(Math.Max(x, y));
            // Console.WriteLine(Math.Abs(-4.7));
            // Console.WriteLine(Math.Round(99.9));
            
            // string txt = "This is still a beginner class in C#";
            // Console.WriteLine("The length of the text is: " + txt.Length);
            // Console.WriteLine(txt.ToUpper());
            // Console.WriteLine(txt.ToLower());

            string firstname = "Ikenna ";
            string othername = "Remigius";
            string name = string.Concat(firstname, othername);
            Console.WriteLine(name);

            Console.WriteLine(firstname.IndexOf('e'));
            Console.WriteLine(name.Substring(6));
            

        }
    }
}
