using System;

public class Palindrome
{
    static public void Main()
  {
    Console.WriteLine("Enter a word or number:"); 
    string palInput = Console.ReadLine();
    var array = palInput.ToCharArray();
    var reversArray = array.Reverse(array);
   
    if (array == reversArray) 
       {
       Console.WriteLine("This is a palindrome!");
       }
     else  
      {      
       Console.WriteLine("Nope, not a palindrome!");
      }
  }
}
