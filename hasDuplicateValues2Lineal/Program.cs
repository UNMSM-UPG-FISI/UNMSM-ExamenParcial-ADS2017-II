using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hasDuplicateValues2Lineal
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = hasDuplicateValues(new int[] { 1, 2, 3 });
            Console.WriteLine("result " + result);

            result = hasDuplicateValuesLineal(new int[] { 1, 2, 3});
            Console.WriteLine("result Lineal " + result);

            Console.ReadLine();
        }

        static bool hasDuplicateValues(int[] numbers)
        {
            long steps = 0;
            for (int i = 0; i < numbers.Count(); i++)
            {
                for (int j = 0; j < numbers.Count(); j++)
                {
                    steps++;
                    if (i != j && numbers[i] == numbers[j])
                    {
                        return true;
                    }
                }
            }

            Console.WriteLine(steps + " steps");
            return false;
        }

        static bool hasDuplicateValuesLineal(int[] numbers)
        {

            long steps = 0;

            foreach (var number in numbers.Distinct())
            {
                steps++;
                if (numbers.Any(item => item.Equals(number))){
                    return true;
                }
            }

            Console.WriteLine(steps + " steps");
            return false;
        }
    }
}
