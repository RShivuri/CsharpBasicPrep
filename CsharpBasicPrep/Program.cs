using System;
using System.Collections.Generic;
using System.Linq;

class ProgrammingExam
{
    // Question 1: Count Commas
    // Write a method CountCommas that counts the number of commas in a string
    static int CountCommas(string aString)
    {
        /* Guidelines:
           - Initialize a counter to 0
           - Loop through each character in the string
           - Increment counter when you find a comma
           - Return the final count
        */
        // Student implementation here
        int commaCount = 0;
        for (int i = 0; i < aString.Length; i++)
        {
            if (aString[i] == ',')
            {
                commaCount++;
            }
        }
        return commaCount;
    }

    static void TestCountCommas()
    {
        Console.WriteLine("Q1 Results:");
        Console.WriteLine($"TotalCount {CountCommas("")} - {CountCommas("") == 0}");
        Console.WriteLine($"TotalCount {CountCommas("VeniVidiVici")} - {CountCommas("VeniVidiVici") == 0}");
        Console.WriteLine($"TotalCount {CountCommas("Veni!,Vidi!,Vici")} - {CountCommas("Veni!,Vidi!,Vici") == 2}");
        Console.WriteLine($"TotalCount {CountCommas("No!,,It's,not.")} - {CountCommas("No!,,It's,not.") == 3}");
        Console.WriteLine($"TotalCount {CountCommas("There's,,,,a,W,O,C,K,E,T,in,my,,,,,pocket")} - {CountCommas("There's,,,,a,W,O,C,K,E,T,in,my,,,,,pocket") == 17}");
    }

    // Question 2: Sum List
    // Write a method Sum that adds all numbers in a list
    static int Sum(List<int> lst)
    {
        /* Guidelines:
           - Initialize a sum variable to 0
           - Use a loop to iterate through the list
           - Add each number to the sum
           - Return the total sum
           - Handle empty list case
        */
        // Student implementation here
        return 0; // Placeholder return statement
    }

    static void TestSum()
    {
        Console.WriteLine("\nQ2 Results:");
        Console.WriteLine(Sum(new List<int>()) == 0);
        Console.WriteLine(Sum(new List<int> { 1 }) == 1);
        Console.WriteLine(Sum(new List<int> { 1, 3, -5, 7 }) == 6);
    }

    // Question 3: String Reversal
    // Write a method ReverseString that returns the reverse of a string
    static string ReverseString(string input)
    {
        /* Guidelines:
           - Convert the string to a character array
           - Reverse the array
           - Convert back to string and return
           - Or use a loop to build the reversed string
        */
        // Student implementation here
        return ""; // Placeholder return statement
    }

    static void TestReverseString()
    {
        Console.WriteLine("\nQ3 Results:");
        Console.WriteLine(ReverseString("") == "");
        Console.WriteLine(ReverseString("a") == "a");
        Console.WriteLine(ReverseString("ab") == "ba");
        Console.WriteLine(ReverseString("abc") == "cba");
        Console.WriteLine(ReverseString("Pablo Ruiz y Picasso") == "ossaciP y ziuR olbaP");
    }

    // Question 4: First Greater or Equal
    // Return index of first string >= given string, or -1 if none
    static int FirstGreaterOrEqual(List<string> lst, string s)
    {
        /* Guidelines:
           - Loop through the list with index
           - Compare each string with the input string
           - Return the first index where string >= input
           - Return -1 if no such string found
           - Use string.Compare for comparison
        */
        // Student implementation here
        return -1; // Placeholder return statement
    }

    static void TestFirstGreaterOrEqual()
    {
        Console.WriteLine("\nQ4 Results:");
        Console.WriteLine(FirstGreaterOrEqual(new List<string>(), "Lucky Seven") == -1);
        Console.WriteLine(FirstGreaterOrEqual(new List<string> { "Brawler", "Gipsy" }, "Lucky") == -1);
        Console.WriteLine(FirstGreaterOrEqual(new List<string> { "Brawl", "Gips", "Mata", "Shao" }, "Lu") == 2);
        Console.WriteLine(FirstGreaterOrEqual(new List<string> { "Brawl", "Shao", "Gips", "Mata" }, "Lu") == 1);

    }

    // Question 5: Triangle Area
    // Calculate area of triangle (0.5*base*height), return -1 for negative inputs
    static double TriangleArea(double baseLength, double height)
    {
        /* Guidelines:
           - Check if either base or height is negative
           - If negative, return -1.0
           - Otherwise calculate area as 0.5 * base * height
           - Round to 4 decimal places
        */
        // Student implementation here
        return -1.0; // Placeholder return statement
    }

    static void TestTriangleArea()
    {
        Console.WriteLine("\nQ5 Results:");
        Console.WriteLine(TriangleArea(3.0, 4.0) == 6.0);
        Console.WriteLine(TriangleArea(-4.0, 3.0) == -1.0);
        Console.WriteLine(TriangleArea(6.34, 2.13) == 6.7521);
    }

    // Question 6: Even Digit Count
    // Count how many digits in the number are even (0 is even)
    static int CountEvenDigits(int n)
    {
        /* Guidelines:
           - Handle negative numbers by taking absolute value
           - Convert number to string to examine each digit
           - Or use mathematical operations to extract digits
           - Count digits that are even (0,2,4,6,8)
           - Return the count
        */
        // Student implementation here
        return 0; // Placeholder return statement
    }

    static void TestCountEvenDigits()
    {
        Console.WriteLine("\nQ6 Results:");
        Console.WriteLine(CountEvenDigits(123456) == 3);
        Console.WriteLine(CountEvenDigits(2468) == 4);
        Console.WriteLine(CountEvenDigits(0) == 1);
        Console.WriteLine(CountEvenDigits(-2468) == 4);
    }

    // Question 7: Collatz Sequence Length
    // Return length of Collatz sequence starting at n (return -1 for n <= 0)
    static int CollatzLength(int n)
    {
        /* Guidelines:
           - If n <= 0, return -1
           - Initialize counter to 1 (counting the starting number)
           - While n != 1:
             - If n is even: n = n/2
             - Else: n = 3*n + 1
             - Increment counter each step
           - Return final count when n reaches 1
        */
        // Student implementation here
        return -1; // Placeholder return statement
    }

    static void TestCollatzLength()
    {
        Console.WriteLine("\nQ7 Results:");
        Console.WriteLine(CollatzLength(10) == 7);  // 10,5,16,8,4,2,1
        Console.WriteLine(CollatzLength(3) == 8);    // 3,10,5,16,8,4,2,1
        Console.WriteLine(CollatzLength(0) == -1);
    }

    // Question 8: Word Count
    // Count words separated by spaces or hyphens (ignore multiple separators)
    static int CountWords(string sentence)
    {
        /* Guidelines:
           - Handle empty string case
           - Split string by both spaces and hyphens
           - Remove empty entries from split results
           - Count the remaining valid words
           - A word is any sequence of characters between separators
        */
        // Student implementation here
        return 0; // Placeholder return statement
    }

    static void TestCountWords()
    {
        Console.WriteLine("\nQ8 Results:");
        Console.WriteLine(CountWords("") == 0);
        Console.WriteLine(CountWords("don't-stray") == 2);
        Console.WriteLine(CountWords("  no              time! - ") == 2);
        Console.WriteLine(CountWords("o-h-n-o e   s") == 6);
    }

    // Question 9: Special Number Validation
    // A number is special if each digit d appears exactly d times (3 appears 3 times)
    static bool IsSpecialNumber(int number)
    {
        /* Guidelines:
           - Convert number to string to examine digits
           - Count occurrences of each digit
           - Check if for every digit d, its count equals d
           - Return true only if all digits satisfy this condition
        */
        // Student implementation here
        return false; // Placeholder return statement
    }

    static void TestIsSpecialNumber()
    {
        Console.WriteLine("\nQ9 Results:");
        Console.WriteLine(IsSpecialNumber(1) == true);
        Console.WriteLine(IsSpecialNumber(1212) == false);
        Console.WriteLine(IsSpecialNumber(3133) == true);
    }

    // Question 10: List Interpolation
    // Insert averages between elements where difference > n until all differences <= n
    static List<double> Interpolate(List<double> lst, double n)
    {
        /* Guidelines:
           - Handle empty list case
           - Use a loop to check differences between consecutive elements
           - When difference > n, insert average between them
           - Repeat until no more insertions needed
           - Return the final list
        */
        // Student implementation here
        return new List<double>(); // Placeholder return statement
    }

    static void TestInterpolate()
    {
        Console.WriteLine("\nQ10 Results:");
        Console.WriteLine(Interpolate(new List<double>(), 0.5).SequenceEqual(new List<double>()));
        Console.WriteLine(Interpolate(new List<double> { 9.0, 10.0 }, 0.5).SequenceEqual(new List<double> { 9.0, 9.5, 10.0 }));
        Console.WriteLine(Interpolate(new List<double> { -7.5, 10.66 }, 5.3).SequenceEqual(new List<double> { -7.5, 1.58, 10.66 }));
    }

    // Question 11: RSA ID Validation
    // Validate RSA ID number using the specified algorithm
    static bool ValidateRsaId(string id)
    {
        /* Guidelines:
           - Check length is exactly 13 digits
           - Sum digits in odd positions (1,3,5,...)
           - Concatenate digits in even positions (2,4,6,...)
           - Double this concatenated number
           - Sum the digits of the doubled number
           - Add this to the odd position sum
           - Calculate check digit: (10 - (total % 10)) % 10
           - Compare with last digit of ID
        */
        // Student implementation here
        return false; // Placeholder return statement
    }

    static void TestValidateRsaId()
    {
        Console.WriteLine("\nQ11 Results:");
        Console.WriteLine(ValidateRsaId("8001015009087") == true);
        Console.WriteLine(ValidateRsaId("8011111111084") == false);
        Console.WriteLine(ValidateRsaId("80010150") == false);
    }

    public static void Main()
    {
        Console.WriteLine("Programming Exam - Implement all methods\n");
        Console.WriteLine("Follow the guidelines in each method comment to complete the implementation.\n");

        TestCountCommas();
        TestSum();
        TestReverseString();
        TestFirstGreaterOrEqual();
        TestTriangleArea();
        TestCountEvenDigits();
        TestCollatzLength();
        TestCountWords();
        TestIsSpecialNumber();
        TestInterpolate();
        TestValidateRsaId();

        Console.WriteLine("\nAll tests completed!");
    }
}