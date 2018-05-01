using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-20): ");
            bool truth = true;
            while (truth)
            {

                try
                {
                    string studentNum = Console.ReadLine();

                    int SNum = int.Parse(studentNum);
                    //bool checkSN = int.TryParse(studentNum, out int SNum);

                    int[] students = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

                    string[] names = { "Mary", "Elizabeth", "Michael", "William", "Linda", "Liz", "David", "Richard", "Joseph", "Susan", "Margaret", "Charles", "Thomas", "Christopher", "Sarah", "Dorothy", "Karen", "Daniel", "Rober", "Jennifer" };

                    string[] hometowns = { "Detroit, MI", "Chicago, IL", "Sterling Heights, MI", "Madison Heights, MI", "Ann Arbor, MI", "Warren, MI", "Centerline, MI", "Yisilanti, MI", "Grand Rapids, MI", "Long Beach, CA", "Lansing, MI", "Flint, MI", "Kalamazoo, MI", "Saginaw, MI", "Dearborn, MI", "Southfield, MI", "Battle Creek, MI", "Novi, MI", "Monroe, MI", "New York City, NY" };

                    string[] foods = { "Pizza", "Fries", "Shawarma", "Fahsa", "Ice Cream", "Donut", "Spaghetti", "Pancakes", "Steak", "Philly Steak Sandwhich", "Fried Chicken", "Rice", "Curry", "Frog Legs", "Offals", "Sushi", "Cake", "Noodles", "Cheesecake", "Lasagne" };

                    Console.Write($"\nStudent {SNum} is {names[SNum - 1]}. What would you like to know about {names[SNum - 1]}? (Enter \"hometown\" or \"favorite food\"): ");

                    bool data = true;
                    while (data)
                    {
                        string input = Console.ReadLine().ToLower();
                        if (input == "hometown")
                        {
                            Console.WriteLine($"\n{names[SNum - 1]} is from {hometowns[SNum - 1]}.\n");
                            data = false;
                        }
                        else if (input == "favorite food")
                        {
                            Console.WriteLine($"\n{names[SNum - 1]} loves all food but especially {foods[SNum - 1]}.\n");
                            data = false;
                        }
                        else
                        {
                            Console.WriteLine("\nThat data does not exist. Please try again. (Enter \"hometown\" or \"favorite food\")");
                            continue;
                        } 
                    }
                    bool check = true;
                    while (check)
                    {
                        Console.Write("Would you like to know more? (enter \"yes\" or \"no\"):  ");
                        string move = Console.ReadLine().ToLower();
                        Console.WriteLine();

                        if (move == "yes")
                        {
                            truth = true;
                            check = false;
                            Console.Write("Which student would you like to learn about next? (enter a number 1-20): ");

                        }
                        else if (move == "no")
                        {
                            truth = false;
                            check = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid, try again!");
                            continue;
                        } 
                    }

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Number inputted is outside of the indicated range, Please try again");
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Format is incorrect!, Please try again");
                }
            }

        }
    }
}
