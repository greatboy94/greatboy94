// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;
using System.Threading.Channels;

class Test1
{

    
    public static void Main(string[] args)
    {

        //EDABIT EASY
        string str = EdabitEasy.MonthName(10);
        Console.WriteLine(str);
        
        double[] MinMax=EdabitEasy.FindMinMax(new double[] { 2,3,5,6,7,8});
        Console.WriteLine(string.Join(" ", MinMax));

        int absSum = EdabitEasy.GetAbsSum(new int[] {2,3,4,5}); 
        Console.WriteLine(absSum);

        long calculateExponent = EdabitEasy.CalculateExponent(10, 2);
        Console.WriteLine(calculateExponent);

        int[] multiplyByLength = EdabitEasy.MultiplyByLength(new int[]{1,2,6,8,9});
        Console.WriteLine(string.Join(" ", multiplyByLength));

        int factorial = EdabitEasy.Factorial(4);
        Console.WriteLine(factorial);

        int vowels = EdabitEasy.CountVowels("Good Game");
        Console.WriteLine(vowels);

        int[] sortNum = EdabitEasy.SortNumsAscending(new int[] {5,8,3,7,1 });
        Console.WriteLine(string.Join(" ", sortNum));

        //EDABIT VERY EASY

        int sum = EdabitVeryEasy.Sum(10, 5);
        Console.WriteLine(sum);

        int convert = EdabitVeryEasy.convert(100);
        Console.WriteLine(convert);

        int addition = EdabitVeryEasy.Addition(10);
        Console.WriteLine(addition);

        int circuitPower = EdabitVeryEasy.CircuitPower(10, 5);
        Console.WriteLine(circuitPower);

        int calcAge = EdabitVeryEasy.CalcAge(28);
        Console.WriteLine(calcAge);

        int triArea = EdabitVeryEasy.triArea(10, 6);
        Console.WriteLine(triArea);

        int remainder = EdabitVeryEasy.Remainder(15, 2);
        Console.WriteLine(remainder);

        bool lessThan = EdabitVeryEasy.LessThanOrEqualToZero(10.50);
        Console.WriteLine(lessThan);

        bool lessThan100 = EdabitVeryEasy.lessThan100(60, 110);
        Console.WriteLine(lessThan100);

        bool isEqual = EdabitVeryEasy.IsEqual(5, 6);
        Console.WriteLine(isEqual);

        string giveMe = EdabitVeryEasy.GiveMeSomething("Hello");
        Console.WriteLine(giveMe);

        bool reverse = EdabitVeryEasy.Reverse(true);
        Console.WriteLine(reverse);

        int howManySeconds = EdabitVeryEasy.HowManySeconds(5);
        Console.WriteLine(howManySeconds);

        string nameString = EdabitVeryEasy.nameString("Alex");
        Console.WriteLine(nameString);

        bool useAnd = EdabitVeryEasy.And(true, false);
        Console.WriteLine(useAnd);

        int points = EdabitVeryEasy.Points(2, 3);
        Console.WriteLine(points);

        string helloName = EdabitVeryEasy.HelloName("Edabit");
        Console.WriteLine(helloName);

        int animals = EdabitVeryEasy.Animals(3, 7, 4);
        Console.WriteLine(animals);

        object getFirstValue = EdabitVeryEasy.GetFirstValue(new object[] {3, 6, 7, 9});
        Console.WriteLine(getFirstValue);

        string greetings = EdabitVeryEasy.Greeting("Andrew");
        Console.WriteLine(greetings);

        int inchesToFeets = EdabitVeryEasy.InchesToFeet(100);
        Console.WriteLine(inchesToFeets);

        bool profitableGamble = EdabitVeryEasy.ProfitableGamble(10.5, 3, 5.5);
        Console.WriteLine(profitableGamble);

        bool timeForMilkAndCookies = EdabitVeryEasy.TimeForMilkAndCookies(2015, 6, 18);
        Console.WriteLine(timeForMilkAndCookies);

        int howManyStickers = EdabitVeryEasy.HowManyStickers(10);
        Console.WriteLine(howManyStickers);

        List<int> printArray = EdabitVeryEasy.PrintArray(5);
        Console.WriteLine(printArray);

        int totalCups = EdabitVeryEasy.TotalCups(5);
        Console.WriteLine(totalCups);

        bool comp = EdabitVeryEasy.Comp("Hello", "Good");
        Console.WriteLine(comp);

        bool shouldServeDrinks = EdabitVeryEasy.ShouldServeDrinks(20, true);
        Console.WriteLine(shouldServeDrinks);

        bool isSafeBridge = EdabitVeryEasy.IsSafeBridge("Well Played");
        Console.WriteLine(isSafeBridge);

        bool equalSlices = EdabitVeryEasy.EqualSlices(10, 3, 2);
        Console.WriteLine(equalSlices);


    }


}