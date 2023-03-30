using System;
					
public class Program
{
    public string procVowel(string param){
        string vowels = "aeiou";
        string result = "";
        foreach(char c in param.ToLower()) {
            if(vowels.Contains(c.ToString())) {
                result += c;
            }
        }
        return result;
    }
    
    public string procConsonant(string param){
        string vowels = "aeiou";
        string result = "";
        foreach(char c in param.ToLower()) {
            if(!Char.IsWhiteSpace(c) && !vowels.Contains(c.ToString())) {
                result += c;
            }
        }
        return result;
    }
    
    public void Main()
    {
        Console.Write("Input one line of words (S) : ");
        string input = Console.ReadLine();
        
        if(String.IsNullOrWhiteSpace(input)) {
            Console.WriteLine("Input is not valid.");
            return;
        }
        
        string charVowel = procVowel(input);
        string charConsonant = procConsonant(input);
            
        Console.WriteLine("Vowel Characters : ");
        Console.WriteLine(charVowel);
        Console.WriteLine("Consonant Characters : ");
        Console.WriteLine(charConsonant);
    }
}