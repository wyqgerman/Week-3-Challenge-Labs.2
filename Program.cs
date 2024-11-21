namespace Week_3_Challenge_Labs._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumDigitsInString("1q2w3e"));       
            Console.WriteLine(SumDigitsInString("L0r3m.1p5um"));  
            Console.WriteLine(SumDigitsInString(""));             
        }

        static int SumDigitsInString(string input)
        {
            int sum = 0;

            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    sum += ch - '0'; 
                }
            }

            return sum;
        }
    }
}
