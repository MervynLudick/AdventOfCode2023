using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public static class _4_1
    {

        public static int Calculate()
        {
            string[] lines = File.ReadAllLines("C:\\Devops\\Repos\\AdventOfCode\\AdventOfCode\\Inputs\\4_1.txt");

            var sum = 0;

            foreach (string line in lines)
            {
                var winningNumbers = line.Split('|')[0].Split(':')[1].Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToHashSet();

                var myNumbers = line.Split('|')[1].Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToList();

                var amount = 0;

                foreach (var number in myNumbers)
                {
                    if (winningNumbers.Contains(number))
                    {
                        if (amount == 0) amount = 1;
                        else
                            amount = amount * 2;
                    }
                }

                sum += amount;

                
            }
            return sum;
        }
       


    }
}
