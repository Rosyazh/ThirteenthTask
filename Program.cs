using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Practice: Develop a console application to perform math statistics operations over the set of numbers inputted by user. Implement text menu to organise the program flow.
*/

namespace ThirteenthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> set1 = new List<int>();
            List<int> set2 = new List<int>();

            IEnumerable<int> set;
            int choice = 0;

            while (choice != 6)
            {
                Console.WriteLine("Menu: \n1. Input sets. \n2. Show sets. \n3. Intersection of sets. \n4. Union of sets. \n5 Difference of sets. \n6 Exit.");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { }
                switch (choice)
                {
                    case 1:
                        set1.Clear();
                        set2.Clear();
                        try
                        {
                            Console.WriteLine("\nEnter the number of values in the set #1.");
                            int n1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nEnter values:");
                            for (int i = 0; i < n1; i++)
                            {
                                int number = Convert.ToInt32(Console.ReadLine());
                                set1.Add(number);
                            }
                            Console.WriteLine("\nEnter the number of values in the set #2.");
                            int n2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nEnter values:");
                            for (int i = 0; i < n2; i++)
                            {
                                int number = Convert.ToInt32(Console.ReadLine());
                                set2.Add(number);
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nIncorrect value.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nSet of numbers #1:");
                        foreach (int n in set1)
                            Console.Write(n + " ");
                        Console.WriteLine("\nSet of numbers #2:");
                        foreach (int n in set2)
                            Console.Write(n + " ");
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.WriteLine("\nIntersection of sets:");
                        set = set1.Intersect(set2);                        
                        foreach (int n in set)
                            Console.Write(n + " ");
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        Console.WriteLine("\nUnion of sets:");
                        set = set1.Union(set2);
                        foreach (int n in set)
                            Console.Write(n + " ");
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        Console.WriteLine("\nDifference of sets:");
                        set = set1.Except(set2);
                        foreach (int n in set)
                            Console.Write(n + " ");
                        Console.WriteLine("\n");
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("The menu doesn't have this item");
                        break;
                }
            }
        }
    }
}
