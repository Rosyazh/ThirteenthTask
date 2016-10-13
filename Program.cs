using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Statistics;

/*
Practice: Develop a console application to perform math statistics operations over the set of numbers inputted by user. Implement text menu to organise the program flow.
*/

namespace ThirteenthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> set1 = new List<double>();
            List<double> set2 = new List<double>();

            IEnumerable<double> set;
            int choice = 0;

            while (choice != 9)
            {
                Console.WriteLine("Menu: \n1. Input sets. \n2. Show sets. \n3. Arithmetic mean. \n4. Variance and Standard Deviation. \n5. Covariance. \n6. Median. \n7. Quantile. \n8. Correlation. \n9. Exit.");
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
                                double number = Convert.ToDouble(Console.ReadLine());
                                set1.Add(number);
                            }
                            Console.WriteLine("\nEnter the number of values in the set #2.");
                            int n2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nEnter values:");
                            for (int i = 0; i < n2; i++)
                            {
                                double number = Convert.ToDouble(Console.ReadLine());
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
                        foreach (double n in set1)
                            Console.Write(n + " ");
                        Console.WriteLine("\nSet of numbers #2:");
                        foreach (double n in set2)
                            Console.Write(n + " ");
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        //Mean
                        Console.WriteLine("\nAverage of the set #1:");
                        Console.WriteLine(Statistics.Mean(set1));
                        Console.WriteLine("\nAverage of the set #2:");
                        Console.WriteLine(Statistics.Mean(set2));
                        break;
                    case 4:
                        Console.WriteLine("\nMeasures with an N normalizer for sets of size N.");
                        Console.WriteLine("\nVariance of the set #1:");
                        Console.WriteLine(Statistics.PopulationVariance(set1));
                        Console.WriteLine("\nStandard Deviation of the set #1:");
                        Console.WriteLine(Statistics.PopulationStandardDeviation(set1));
                        Console.WriteLine("\nVariance of the set #2:");
                        Console.WriteLine(Statistics.PopulationVariance(set2));
                        Console.WriteLine("\nStandard Deviation of the set #2:");
                        Console.WriteLine(Statistics.PopulationStandardDeviation(set2));

                        Console.WriteLine("\nMeasures with an N-1 normalizer for sets of size N.");
                        Console.WriteLine("\nVariance of the set #1:");
                        Console.WriteLine(Statistics.Variance(set1));
                        Console.WriteLine("\nStandard Deviation of the set #1:");
                        Console.WriteLine(Statistics.StandardDeviation(set1));
                        Console.WriteLine("\nVariance of the set #2:");
                        Console.WriteLine(Statistics.Variance(set2));
                        Console.WriteLine("\nStandard Deviation of the set #2:");
                        Console.WriteLine(Statistics.StandardDeviation(set2));
                        break;
                    case 5:
                        Console.WriteLine("\nMeasures with an N normalizer for sets of size N.");
                        Console.WriteLine("\nCovariance of the sets:");
                        Console.WriteLine(Statistics.PopulationCovariance(set1,set2));

                        Console.WriteLine("\nMeasures with an N-1 normalizer for sets of size N.");
                        Console.WriteLine("\nCovariance of the sets:");
                        Console.WriteLine(Statistics.Covariance(set1,set2));
                        break;
                    case 6:
                        Console.WriteLine("\nMedian of the set #1.");
                        Console.WriteLine(Statistics.Median(set1));
                        Console.WriteLine("\nMedian of the set #2.");
                        Console.WriteLine(Statistics.Median(set2));
                        break;
                    case 7:
                        Console.WriteLine("\nQuantile of the set #1:");
                        Console.WriteLine(Statistics.Quantile(set1, 0.6));
                        Console.WriteLine("\nQuantile of the set #2:");
                        Console.WriteLine(Statistics.Quantile(set1, 0.5));
                        break;
                    case 8:
                        Console.WriteLine("\nCorrelation of the sets.");
                        Console.WriteLine(Correlation.Pearson(set1, set2));
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("The menu doesn't have this item");
                        break;
                }
            }
        }
    }
}
