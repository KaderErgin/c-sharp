using System;
using System.Collections.Generic;

namespace PatikaHomeWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();

            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);

            List<string> colors = new List<string>();

            colors.Add("yellow");
            colors.Add("orange");
            colors.Add("blue");
            colors.Add("grey");
            colors.Add("purple");
            colors.Add("red");

            //count

            Console.WriteLine("Count of numbers list : " + nums.Count);
            Console.WriteLine("Count of colors list : " + colors.Count);

            Console.WriteLine("Number List : ");
            foreach (var num in nums)
                Console.Write(num + ", ");
            Console.Write("\n");

            Console.WriteLine("Color List : ");
            foreach (var color in colors)
                Console.Write(color + ", ");
            Console.Write("\n");

            //remove element of list

            nums.Remove(4);
            colors.Remove("pink");

            nums.RemoveAt(0);
            colors.RemoveAt(2);

            nums.ForEach(num => Console.WriteLine(num));
            colors.ForEach(color => Console.WriteLine(color));

            //searching 
            if (nums.Contains(10))
                Console.WriteLine("List contains 10!");
            else
                Console.WriteLine("List does not contain 10!");

            if (colors.Contains("red"))
                Console.WriteLine("List contains red!");

            //Searching by index number --Check the list indexing number for part 
            Console.WriteLine(colors.BinarySearch("red"));
            Console.WriteLine(nums.BinarySearch(3));

            //Convert array to list
            string[] animals = { "dog", "monkey", "bird", "fox", "fish" };
            List<string> listAnimals = new List<string>(animals);
            listAnimals.ForEach(animal => Console.WriteLine(animal));

            //clear all element of list
            listAnimals.Clear();

            //
            List<Users> userList = new List<Users>();

            Users user1 = new Users();
            user1.Name = "Kader";
            user1.LastName = "Ergin";
            user1.Age = 26;

            Users user2 = new Users();
            user2.Name = "Gulce";
            user2.LastName = "Cakır";
            user2.Age = 4;

            userList.Add(user1);
            userList.Add(user2);

            List<Users> newList = new List<Users>();

            newList.Add(new Users()
            {
                Name = "Derya",
                LastName = "Yılmaz",
                Age = 30
            });

            foreach (Users user in userList)
            {
                Console.WriteLine("Username : " + user.Name);
                Console.WriteLine("Surname : " + user.LastName);
                Console.WriteLine("Age : " + user.Age);
            }

            Console.WriteLine(newList[0].Name);
            Console.WriteLine(newList[0].LastName);
            Console.WriteLine(newList[0].Age);

            //Stopping console
            Console.ReadKey();
        }

            //Encapsulation
        public class Users
        {
            string name;
            string lastName;
            int age;

           
            public string Name { get => name; set => name = value; }
            public string LastName { get => lastName; set => lastName = value; }
            public int Age { get => age; set => age = value; }

        }
    }
}
