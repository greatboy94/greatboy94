// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        //ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.
        //Your task is to create a function that takes a string and returns true if the PIN is valid and false if it's not.
        // static bool ValidatePIN(string pin) 
        // {
        //     return  (pin.Length == 4 || pin.Length == 6) && pin.All(char.IsDigit);
        // }
        
        
        //Equality Check
        //In this challenge, you must verify the equality of two different values given the parameters a and b.
        // public static bool CheckEquality(object a, object b)
        // {
        //     object res=a.GetType();
        //     object res1=b.GetType();
		      //
        //     if(res.Equals(res1) && a.Equals(b))
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }
        
        
        //Reverse the Case
        //Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
        // public static string ReverseCase(string str) 
        // {
        //     char[] words=str.ToCharArray();
        //     string res="";
        //     foreach(char el in words){
        //         if(char.IsLower(el)){
        //             res+=el.ToString().ToUpper();
        //         }else if(char.IsUpper(el)){
        //             res+=el.ToString().ToLower();
        //         }else{
        //             res+=el;
        //         }
        //     }
        //     return res;
        // }
        
        
        //Find the Bomb
        //Create a function that finds the word "bomb" in the given string (not case sensitive).
        //If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".
        // public static string Bomb(string txt)
        // {
        //     string res = txt.ToLower();
        //     bool word = res.Contains("bomb");
        //     if (word == true)
        //     {
        //         return "Duck!!!";
        //     }
        //     else
        //     {
        //         return "There is no bomb, relax.";	
        //     }
        // }
        
        
        //Convert All Array Items to String
        // public static string[] ParseArray (object[] arr)
        // {
        //     string[] res = new string[arr.Length];
        //     for(int i = 0; i < arr.Length; i++)
        //         res[i] = arr[i].ToString();
        //     return res;
        // }
        
        
        //Find the Largest Numbers in a Group of Arrays
        // public static double[] FindLargest(double[][] values) 
        // {
        //     double[] res = new double[values.Length];
        //     for (int i = 0; i < values.Length; i++)
        //         res[i] = values[i].Max();
        //     return res;
        // }
        
        
        //The Collatz Conjecture
        //If n is even -> n / 2
        //If n is odd -> n * 3 + 1
        // public static int collatz(int num)
        // {
        //     int count = 0;
        //     while (num > 1)
        //     {      
        //         if (num % 2 == 0)
        //         {
        //             num /= 2;
        //             count++;
        //         }
        //         else if (num % 2 == 1)
        //         {
        //             num = num * 3 + 1;
        //             count++;
        //         }
        //     }
        //     return count;
        // }
        
        
        //Find the Characters Counterpart Char Code
        // public static int CounterpartCharCode(char symbol) 
        // {
        //     if (char.IsUpper(symbol)){
        //         return char.ToLower(symbol);
        //     }else if (char.IsLower(symbol)){
        //         return char.ToUpper(symbol);
        //     }
        //     return symbol;
        // }
        
        
        //Fraction Greater Than One
        //Given a fraction as a string, return whether or not it is greater than 1 when evaluated.
        // public static bool GreaterThanOne(string str)
        // {
        //     string[] arr = str.Split('/');
        //     int num1 = Convert.ToInt32(arr[0]);
        //     int num2 = Convert.ToInt32(arr[1]);
        //     if (num1 > num2){
        //         return true;
        //     }else{
        //         return false;
        //     }
        // }
        
        
        //Positive Count / Negative Sum
        // public static int[] CountPosSumNeg(double[] arr) 
        // {
        //     int countPos=0;
        //     int sumNeg=0;
        //     for(var i = 0 ; i < arr.Length; i++){
        //         if(arr[i] >= 0){
        //             countPos++;
        //         }else{
        //             sumNeg = sumNeg + (int)arr[i];
        //         }
        //     }
			     //
        //     return new int[]{countPos, sumNeg};
        // }
        
        
        

        
    }
}