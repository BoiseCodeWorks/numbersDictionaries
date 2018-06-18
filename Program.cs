using System;
using System.Collections.Generic;

namespace greatest_least
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> numbers = new List<int>(){1,4,5,7,3,-23,56,7,42,1,45,6,3,2,90};
            // int greatest = numbers[0];
            // int least = numbers[0]; 
            // numbers.ForEach(n =>{
            //     if(n > greatest){
            //         greatest = n;
            //     }
            //     if(n < least){
            //         least = n;
            //     }
            // });
            // System.Console.WriteLine(greatest + least);

            User mark = new User("Mark", "iheartcode", "Mac & Cheese");
            User ramsey = new User("Ramsey", "clocksrfun", "Thyme");
            User christian = new User("Christian", "iheartlemonbars", "Sandwiches");

            Dictionary<string, User> Users = new Dictionary<string, User>();
            Users.Add(mark.Name, mark);
            Users.Add(ramsey.Name, ramsey);
            Users.Add(christian.Name, christian);

            System.Console.WriteLine("Please Provide your username:");
            string nameInput = Console.ReadLine();
            System.Console.WriteLine("Please Provide your Password: ");
            string passInput = Console.ReadLine();

            //validate username and password then if accurate return favorite food
            if(Users.ContainsKey(nameInput)){
                System.Console.WriteLine(Users[nameInput].GetFood(passInput));
            }else{
                System.Console.WriteLine("Invalid username / password");
            }
        }
    }
}
