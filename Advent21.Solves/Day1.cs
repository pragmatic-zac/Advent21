namespace Advent21.Solves
{
    public class Day1
    {
        // count the number of times a depth measurement increases from the previous measurement
        public int SolvePartOne()
        {
            int counter = 0;

            var lines = File.ReadAllLines("C:\\Users\\Zachary\\source\\repos\\Advent21\\Advent21\\Input\\day1.txt");
            
            for (int i = 1; i < lines.Length; i++)
            {
                if (int.Parse(lines[i]) > int.Parse(lines[i - 1]))
                {
                    counter++;
                }
            }

            return counter;
        }

        // count the number of times the sum of measurements in this sliding window increases from the previous sum
        public int SolvePartTwo()
        {
            int counter = 0;

            var lines = File.ReadAllLines("C:\\Users\\Zachary\\source\\repos\\Advent21\\Advent21\\Input\\day1.txt");

            for (int i = 3; i < lines.Length; i++)
            {
                var previousSum = int.Parse(lines[i - 3]) + int.Parse(lines[i - 2]) + int.Parse(lines[i - 1]);

                var currentSum = int.Parse(lines[i - 2]) + int.Parse(lines[i - 1]) + int.Parse(lines[i]);

                if (currentSum > previousSum) counter++;
            }

            return counter;
        }
    }
}
