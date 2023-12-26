using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class _7_1
    {
        public static int Calculate()
        {
            var lines = File.ReadAllLines("C:\\Devops\\Repos\\AdventOfCode\\AdventOfCode\\Inputs\\7.txt");

            List<Hand> hands = new();

            foreach (string line in lines)
            {
                var strings = line.Split(' ');
                Hand hand = new(strings[0], int.Parse(strings[1]));
                hands.Add(hand);
            }

            hands = hands.OrderBy(x => x.PrimaryRating).ThenBy(x => x.SecondaryRating).ToList();

            var amount = 0;

            for (int i = 0; i< hands.Count; i++)
            {
                amount += hands[i].Bet * (i + 1);
            }

            return amount;


        }

        public class Hand
        {
            public int PrimaryRating { get; set; }
            public string SecondaryRating { get; set; } = "";
            public string Cards { get; set; }
            public int Bet { get; set; }

            public Hand(string cards, int bet)
            {
                Cards = cards;
                Bet = bet;

                CalculatePrimaryRating();
                CalculateSecondaryRating();
            }

            private void CalculatePrimaryRating()
            {
                var hasChecked = new HashSet<char>();
                foreach (char c in Cards)
                {
                    if (hasChecked.Contains(c)) continue;
                    hasChecked.Add(c);

                    var count = Cards.Count(x => x == c);

                    if (count == 2) PrimaryRating += 1;

                    if (count == 3) PrimaryRating += 3;

                    if (count == 4) PrimaryRating += 5;

                    if (count == 5) PrimaryRating += 6;
                }
            }

            private void CalculateSecondaryRating()
            {
                var cardRatings = new Dictionary<char, char>
                {
                    {'2', 'A' },
                    {'3', 'B' },
                    {'4', 'C' },
                    {'5', 'D' },
                    {'6', 'E' },
                    {'7', 'F' },
                    {'8', 'G' },
                    {'9', 'H' },
                    {'T', 'I' },
                    {'J', 'J' },
                    {'Q', 'K' },
                    {'K', 'L' },
                    {'A', 'M' }
                };

                foreach (char  card in Cards)
                {
                    SecondaryRating += cardRatings[card];
                }
            }
        }

        
    }
}
