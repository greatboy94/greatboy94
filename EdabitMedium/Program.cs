// See https://aka.ms/new-console-template for more information


class Program
{
    public static void Main(string[] args)
    {
        bool validatePin = EdabitMediumTasks.ValidatePIN("123856");
        Console.WriteLine(validatePin);

        bool checkEquality = EdabitMediumTasks.CheckEquality("hello",5);
        Console.WriteLine(checkEquality);

        string reverseCase = EdabitMediumTasks.ReverseCase("Good Game");
        Console.WriteLine(reverseCase);

        string bomb = EdabitMediumTasks.Bomb("bombss");
        Console.WriteLine(bomb);

        string[] parseArray = EdabitMediumTasks.ParseArray(new object[] {32, 12, 3});
        Console.WriteLine(string.Join(" ", parseArray));
        
        // double[] findLargest=EdabitMediumTasks.FindLargest(new double[][] {{4, 2, 7, 1}, {20, 70, 40, 90}, {1, 2, 0}});
        // Console.WriteLine(findLargest);

        int collatz = EdabitMediumTasks.Collatz(12);
        Console.WriteLine(collatz);

        int counterpartCharCode = EdabitMediumTasks.CounterpartCharCode('A');
        Console.WriteLine(counterpartCharCode);

        bool greaterThanOne = EdabitMediumTasks.GreaterThanOne("2/5");
        Console.WriteLine(greaterThanOne);

        int[] countPosSumNeg = EdabitMediumTasks.CountPosSumNeg(new double[] {10,-8,5,-2,3});
        Console.WriteLine(string.Join(" ", countPosSumNeg));

        string toScottishScreaming = EdabitMediumTasks.ToScottishScreaming("Mr. Fox was very naughty");
        Console.WriteLine(toScottishScreaming);

        bool isPalindrome = EdabitMediumTasks.IsPalindrome(1221);
        Console.WriteLine(isPalindrome);

        string findNemo = EdabitMediumTasks.FindNemo("nemooo");
        Console.WriteLine(findNemo);

        string removeSpecialCharacters = EdabitMediumTasks.RemoveSpecialCharacters("%fd76$fd(-)6GvKlO.");
        Console.WriteLine(removeSpecialCharacters);

        string century = EdabitMediumTasks.Century(1999);
        Console.WriteLine(century);

        string encrypt = EdabitMediumTasks.Encrypt("Good");
        Console.WriteLine(encrypt);

        string sevenBoom = EdabitMediumTasks.SevenBoom(new int[] {5,6,2,7});
        Console.WriteLine(sevenBoom);
    }
}