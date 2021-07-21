using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1 {
    class Program {
        static void Main(string[] args) {

            int[] ranks = new int[9];
            ranks[0] = 3;
            ranks[1] = 4;
            ranks[2] = 3;
            ranks[3] = 0;
            ranks[4] = 2;
            ranks[5] = 2;
            ranks[6] = 3;
            ranks[7] = 0;
            ranks[8] = 0;

            if (Validation.ValidationTheArray(ranks)) {

                Console.WriteLine(Solution.solution(ranks));
                Console.ReadLine();
            } else Console.ReadLine();

            ranks = new int[3];
            ranks[0] = 4;
            ranks[1] = 2;
            ranks[2] = 0;

            if (Validation.ValidationTheArray(ranks)) {

                Console.WriteLine(Solution.solution(ranks));
                Console.ReadLine();
            } else Console.ReadLine();

            ranks = new int[6];
            ranks[0] = 4;
            ranks[1] = 4;
            ranks[2] = 3;
            ranks[3] = 3;
            ranks[4] = 1;
            ranks[5] = 0;

            if (Validation.ValidationTheArray(ranks)) {

                Console.WriteLine(Solution.solution(ranks));
                Console.ReadLine();
            } else Console.ReadLine();
        }
    }

    class Solution
    {
        public static int solution(int[] ranks)
        {

            return SoldiersRank.CalcRank(ranks);
        }
    }

    class Validation{
        public static bool ValidationTheArray(int[] ranks) {

            bool validation = true;

            foreach (int i in ranks) {

                if (i >= 0 && i <= 1000000000 && validation) validation = true;

                else validation = false;
            }

            return validation;
        }
    }

    class SoldiersRank {

        public static List<int> OrganizeList(int[] ranks) {

            List<int> allRanks = new List<int>();

            for(int i =0; i<ranks.Length; i++) {

                allRanks.Add(ranks[i]);
            }

            allRanks = allRanks.OrderByDescending(allRank => allRank).ToList();

            return allRanks;
        }
        public static int CalcRank(int[] ranks) {

            List<int> ranksOrderDescending = OrganizeList(ranks);
            bool pulse = false;
            int count = 0;

            for (int i = 1; i < ranksOrderDescending.Count(); i++) {

                if ((ranksOrderDescending[i - 1] - ranksOrderDescending[i]) == 1) {

                    pulse = true;
                    count++;
                }
                else if ((ranksOrderDescending[i - 1] - ranksOrderDescending[i]) == 0 && pulse) {

                    count++;
                }
                else {

                    pulse = false;
                }
            }
            return count;
        }
    }
}