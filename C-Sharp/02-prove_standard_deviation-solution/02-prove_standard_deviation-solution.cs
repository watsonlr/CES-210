// See https://aka.ms/new-console-template for more information

/********
CSE212 
(c) BYU-Idaho
02-Prove - Problem 1.2

It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
to post it online.  Storage into a personal and private repository (e.g. private
GitHub repository, unshared Google Drive folder) is acceptable.

//--- Created from: dotnet new console. See https://aka.ms/new-console-template for more information ---//
********/
using System;
using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("CSE212:  02-Prove - Problem 2 - Solution");  // Comment out this line
        test_sd();

        //public double standard_deviation_1(List<int> numbers)
        double standard_deviation_1(int[] numbers)
        {
            int total = 0, count = 0;
            foreach (var number in numbers)
            {
                total += number;
                count++;
            }
            double avg = total / count;
            double sum_squared_differences = 0;
            foreach (var number in numbers)
            {
                sum_squared_differences += Math.Pow(number - avg, 2);
            }
            double variance = Math.Sqrt(sum_squared_differences / count);
            return variance;
        }


    double standard_deviation_2(int[] numbers)
        {
        double sum_squared_differences = 0;
        int count_numbers = 0;
        int total = 0;
        int count = 0;
        foreach(var number in numbers)
            {
            total = 0;
            count = 0;
            foreach(var value in numbers)
                {
                total += value;
                count += 1;
                }
            double avg = total / count;
            sum_squared_differences += Math.Pow(number - avg, 2);
            count_numbers += 1;
            }
        double variance = Math.Sqrt(sum_squared_differences / count);
        return variance;
        }




        double standard_deviation_3(int[] numbers)
        {
            int count = numbers.Length;     // instead of manually counting, use built-in attribute
            int sum = numbers.Sum();        // built-in sum method
            double avg = sum / count;
            // double builtin_average = numbers.Average();     // Short cut -- not used but could ...
            double sum_squared_differences = 0;
            foreach (var number in numbers)
            {
                sum_squared_differences += Math.Pow(number - avg, 2);
            }
            double variance = Math.Sqrt(sum_squared_differences / count);
            return variance;
        }


        void test_sd()
            {
            int[] test_numbers = { 600, 470, 170, 430, 300 };
            tb_item test1 = new tb_item(test_numbers,147.322);
            Console.WriteLine("testing");
            double variance1 = standard_deviation_1(test_numbers);  // Should be 147.322 
            double variance2 = standard_deviation_2(test_numbers);  // Should be 147.322 
            double variance3 = standard_deviation_3(test_numbers);  // Should be 147.322 
                                                                    //double variance2 =  deviations.standard_deviation_2(numbers);  // Should be 147.322 
                                                                    //double variance3 =  deviations.standard_deviation_3(numbers);  // Should be 147.322 
            Console.WriteLine("std deviation 1: " + variance1);  // Should be 147.322 
            Console.WriteLine("std deviation 2: " + variance2);  // Should be 147.322 
            Console.WriteLine("std deviation 3: " + variance3);  // Should be 147.322 
            //Console.WriteLine(standard_deviation_2(numbers))  # Should be 147.322 
            //Console.WriteLine(standard_deviation_3(numbers))  # Shou
            }
        }
    }

// List<int> test_numbers_list = new List<int>   {600, 470, 170, 430, 300};

class tb_item {
        public int[] numbers;
        public double answer;
        public tb_item(int[] numbers_in,double answer_in)
            {numbers = numbers_in;
             answer = answer_in;}
        }
