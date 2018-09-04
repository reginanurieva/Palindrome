using System;

using System.Collections.Generic;

public class Program
{
  public static bool validatePalindrome(string inputString)
  {
    // EX) inputString = "Hello olleH" => 5
    // "SooooS" => 3
    // inputStringLength / 2
    // get the length of input string
    int inputStringLength = inputString.Length;
    char [] inputCharacters = inputString.ToCharArray();
    // get "Hello " from inputString
    // compare "Hello " with " olleH"
    // ToCharArray(startIndex, length of the output array)
    // if the length of input string is even, length/2
    // if the length of input string is odd, (length+1)/2
    char [] firstHalfOfInputString = inputString.ToCharArray(0, (int)Math.Ceiling((double)inputStringLength / 2));
    //11 / 2 = 5;
    // (float)11 == 11.0
    //11.0 / 2 = 5.5;
    //5.5 => 6, 5 => 5
    for (int i = inputStringLength-1; i >= inputStringLength / 2; i--) {
      if (firstHalfOfInputString[inputStringLength-1-i] != inputCharacters[i])
      {
        return false;
      }
    }
    return true;

  }
  public static void Main()
  {
    Console.WriteLine("Please enter a word or sentence to see if it contains the Palindrome!");
    string inputString = Console.ReadLine();
    if (validatePalindrome(inputString) == true)
    {
      Console.WriteLine("Palindrome");
    }
    else
    {
      Console.WriteLine("Not a palindrome");
    }
  }
}

// if we use inputString == reversedString
// it always return false
// == operator compares the memory address of each string in computer
//

// get a string as a input

// convert the string to character array with inputString.ToCharArray();

// reverse the order of characters through Array.Reverse(arrName)

// convert char array to string with string reversedString = new string(charArr);

// compare two strings with string1.equals(string2)

// return result
