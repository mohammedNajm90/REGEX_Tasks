class Program
{
    static void Main()
    {
        // Question 1: Match all phone numbers in a local format like 0790xxxxxxx.
        Console.WriteLine($"Question 1: {RegexFunctions.MatchPhonNumberLocalFormat("My number is 07901234567.")}");           // Output: 07901234567
    }
}