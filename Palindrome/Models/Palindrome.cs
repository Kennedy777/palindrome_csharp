using System;

public class Palindrome
{
    static public void Main()
  {
    Console.WriteLine("Enter a word or number:"); 
    string palInput = Console.ReadLine();
    string string2 = "";

    for(int i = palInput.Length-1;i > -1; i--)
    {
        string2 = string2 + palInput[i];
    }


    // var array = palInput.ToCharArray();
    // var reversArray = array.Reverse(array);
   
    if (string2 == palInput) 
       {
       Console.WriteLine("This is a palindrome!");
       }
     else  
       {      
       Console.WriteLine("Nope, not a palindrome!");
       }
  }
}
