
public class EdabitMediumTasks
{
    //ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.
    //Your task is to create a function that takes a string and returns true if the PIN is valid and false if it's not.
    public static bool ValidatePIN(string pin)
    {
        return (pin.Length == 4 || pin.Length == 6) && pin.All(char.IsDigit);
    }


    //Equality Check
    //In this challenge, you must verify the equality of two different values given the parameters a and b.
    public static bool CheckEquality(object a, object b)
    {
        object res = a.GetType();
        object res1 = b.GetType();

        if (res.Equals(res1) && a.Equals(b))
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    //Reverse the Case
    //Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
    public static string ReverseCase(string str)
    {
        char[] words = str.ToCharArray();
        string res = "";
        foreach (char el in words)
        {
            if (char.IsLower(el))
            {
                res += el.ToString().ToUpper();
            }
            else if (char.IsUpper(el))
            {
                res += el.ToString().ToLower();
            }
            else
            {
                res += el;
            }
        }

        return res;
    }


    //Find the Bomb
    //Create a function that finds the word "bomb" in the given string (not case sensitive).
    //If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".
    public static string Bomb(string txt)
    {
        string res = txt.ToLower();
        bool word = res.Contains("bomb");
        if (word == true)
        {
            return "Duck!!!";
        }
        else
        {
            return "There is no bomb, relax.";
        }
    }


    //Convert All Array Items to String
    public static string[] ParseArray(object[] arr)
    {
        string[] res = new string[arr.Length];
        for (int i = 0; i < arr.Length; i++)
            res[i] = arr[i].ToString();
        return res;
    }


    //Find the Largest Numbers in a Group of Arrays
    public static double[] FindLargest(double[][] values)
    {
        double[] res = new double[values.Length];
        for (int i = 0; i < values.Length; i++)
            res[i] = values[i].Max();
        return res;
    }


    //The Collatz Conjecture
    //If n is even -> n / 2
    //If n is odd -> n * 3 + 1
    public static int Collatz(int num)
    {
        int count = 0;
        while (num > 1)
        {
            if (num % 2 == 0)
            {
                num /= 2;
                count++;
            }
            else if (num % 2 == 1)
            {
                num = num * 3 + 1;
                count++;
            }
        }

        return count;
    }


    //Find the Characters Counterpart Char Code
    public static int CounterpartCharCode(char symbol)
    {
        if (char.IsUpper(symbol))
        {
            return char.ToLower(symbol);
        }
        else if (char.IsLower(symbol))
        {
            return char.ToUpper(symbol);
        }

        return symbol;
    }


    //Fraction Greater Than One
    //Given a fraction as a string, return whether or not it is greater than 1 when evaluated.
    public static bool GreaterThanOne(string str)
    {
        string[] arr = str.Split('/');
        int num1 = Convert.ToInt32(arr[0]);
        int num2 = Convert.ToInt32(arr[1]);
        if (num1 > num2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    //Positive Count / Negative Sum
    public static int[] CountPosSumNeg(double[] arr)
    {
        int countPos = 0;
        int sumNeg = 0;
        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                countPos++;
            }
            else
            {
                sumNeg = sumNeg + (int) arr[i];
            }
        }

        return new int[] {countPos, sumNeg};
    }


    //Scottish Screaming
    //A strong Scottish accent makes every vowel similar to an "e", so you should replace every vowel with an "e".
    //Additionally, it is being screamed, so it should be in block capitals.
    public static string ToScottishScreaming(string str)
    {
        str = str.Replace('a', 'e');
        str = str.Replace('i', 'e');
        str = str.Replace('o', 'e');
        str = str.Replace('u', 'e');

        return str.ToUpper();
    }


    //Check if a Number is a Palindrome
    public static bool IsPalindrome(int num)
    {
        int val = num;
        int res = 0;
        while (val > 0)
        {
            res = res * 10 + val % 10;
            val = val / 10;
        }

        return res == num;
    }


    //Finding Nemo
    //You're given a string of words. You need to find the word "Nemo", and return a string like this: "I found Nemo at [the order of the word you find Nemo]!".
    //If you can't find Nemo, return "I can't find Nemo :(".
    public static string FindNemo(string sentence)
    {
        var position = Array.IndexOf(sentence.Split(' '), "Nemo");
        if (position < 0)
        {
            return "I can't find Nemo :(";
        }
        else
        {
            return $"I found Nemo at {position + 1}!";
        }
    }

    //Remove All Special Characters from a String
    public static string RemoveSpecialCharacters(string str)
    {
        string[] chars = new string[]
        {
            ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "(", ")", ":", "|", "[", "]"
        };

        for (int i = 0; i < chars.Length; i++)
        {
            if (str.Contains(chars[i]))
            {
                str = str.Replace(chars[i], "");
            }
        }

        return str;
    }


    //Get the Century---I did with wrong way I think )))
    public static string Century(int year)
    {
        if (year == 1000)
        {
            return "10th century";
        }
        else if (year > 1000 && year < 1101)
        {
            return "11th century";
        }
        else if (year > 1100 && year < 1201)
        {
            return "12th century";
        }
        else if (year > 1200 && year < 1301)
        {
            return "13th century";
        }
        else if (year > 1300 && year < 1401)
        {
            return "14th century";
        }
        else if (year > 1400 && year < 1501)
        {
            return "15th century";
        }
        else if (year > 1500 && year < 1601)
        {
            return "16th century";
        }
        else if (year > 1600 && year < 1701)
        {
            return "17th century";
        }
        else if (year > 1700 && year < 1801)
        {
            return "18th century";
        }
        else if (year > 1800 && year < 1901)
        {
            return "19th century";
        }
        else if (year > 1900 && year < 2001)
        {
            return "20th century";
        }
        else if (year > 2000 && year < 2101)
        {
            return "21st century";
        }
        else
        {
            return "Out of Bound";
        }
    }

    //The Karaca's Encryption Algorithm
    //Input: "apple"
    //Step 1: Reverse the input: "elppa"
    //Step 2: Replace all vowels using the following chart:
    // a => 0
    // e => 1
    // i => 2
    // o => 2
    // u => 3
    // "1lpp0"
    // Step 3: Add "aca" to the end of the word: "1lpp0aca"
    // Output: "1lpp0aca"

    public static string Encrypt(string word)
    {
        string aca = "aca";
        char[] arr = word.ToCharArray();
        string reversedString = String.Empty;
        for (int i = arr.Length - 1; i > -1; i--)
        {
            reversedString += arr[i];
            reversedString = reversedString.Replace('a', '0');
            reversedString = reversedString.Replace('e', '1');
            reversedString = reversedString.Replace('i', '2');
            reversedString = reversedString.Replace('o', '2');
            reversedString = reversedString.Replace('u', '3');
        }

        return reversedString + aca;
    }


    //Seven Boom!
    //Create a function that takes a list of numbers and return "Boom!" if the digit 7 appears in the array.
    //Otherwise, return "there is no 7 in the array".
    public static string SevenBoom(int[] arr)
    {
        foreach (int el in arr)
        {
            if (el.ToString().Contains("7"))
                return "Boom!";
        }

        return "there is no 7 in the array";
    }
}