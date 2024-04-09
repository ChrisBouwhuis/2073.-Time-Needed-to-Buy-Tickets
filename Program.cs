using ClassLib;
namespace _2073._Time_Needed_to_Buy_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] tickets = [84, 49, 5, 24, 70, 77, 87, 8];
            int k = 3;
            int result = solution.TimeRequiredToBuy(tickets, k);
            Console.WriteLine(result);
        }
    }
}
