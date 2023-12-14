using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class _7_2
    {
        public static int Calculate()
        {
            var lines = File.ReadAllLines("C:\\Devops\\Repos\\AdventOfCode\\AdventOfCode\\Inputs\\7.txt");

            List<Hand> hands = [];

            foreach (string line in lines)
            {
                var strings = line.Split(' ');
                Hand hand = new(strings[0], int.Parse(strings[1]));
                hands.Add(hand);
            }

            hands = hands.OrderBy(x => x.PrimaryRating).ThenBy(x => x.SecondaryRating).ToList();

            var amount = 0;

            for (int i = 0; i < hands.Count; i++)
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

                var score = 0;
                foreach (char c in Cards)
                {
                    if (hasChecked.Contains(c)) continue;
                    hasChecked.Add(c);

                    var count = Cards.Count(x => x == c);

                    if (count == 2) score += 1;

                    if (count == 3) score += 3;

                    if (count == 4) score += 5;

                    if (count == 5) score += 6;
                }

                var numJ = Cards.Count(x => x == 'J');

                if (numJ == 4) score = 6;
                if (numJ == 3)
                {
                    if (score == 3) score = 5;
                    else if (score == 4) score = 6;
                }
                if (numJ == 2)
                {
                    if (score == 1) score = 3;
                    else if (score == 2) score = 5;
                    else if (score == 4) score = 6;
                }
                if (numJ == 1)
                {
                    if (score == 0) score = 1;
                    else if (score == 1) score = 3;
                    else if (score == 2) score = 4;
                    else if (score == 3) score = 5;
                    else if (score == 5) score = 6;
                }

                PrimaryRating = score;
            }

            private void CalculateSecondaryRating()
            {
                var cardRatings = new Dictionary<char, char>
                {
                    {'J', 'A' },
                    {'2', 'B' },
                    {'3', 'C' },
                    {'4', 'D' },
                    {'5', 'E' },
                    {'6', 'F' },
                    {'7', 'G' },
                    {'8', 'H' },
                    {'9', 'I' },
                    {'T', 'J' },
                    {'Q', 'K' },
                    {'K', 'L' },
                    {'A', 'M' }
                };

                foreach (char card in Cards)
                {
                    SecondaryRating += cardRatings[card];
                }
            }
        }
    }
}
