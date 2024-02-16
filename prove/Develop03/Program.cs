using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    private static bool keepGoing;
    static void Main(string[] args)
    {
        Console.Clear();
        Run();
    }
    static public void Run(){
        var refrence = new Refrence("20","21");
        var verseText = refrence.GetVerse();
        var scripture = new Scripture();
        var words = scripture.Seperate(verseText);
        var title = refrence.Display();
        keepGoing = true;
        Console.Clear();
        Console.WriteLine($"{title} {verseText}");
        while (keepGoing == true){
            Console.WriteLine("\n\npress Enter to continue, and Escape to Quit");
            if (Console.ReadKey().Key == ConsoleKey.Enter){
                Console.Clear();
                var word = new Word();
                word.Hide(words);
                var word1 = new Word();
                word1.Hide(words);
                var word2 = new Word();
                word2.Hide(words);
                Console.Write(title);
                foreach(string palabra in words){
                    Console.Write("{0} ", string.Join(" ", palabra));
                }
                if (Scripture.hiddenWords.Count == words.Length){
                    keepGoing = false;
                    break;
                }
            }
            else if(Console.ReadKey().Key == ConsoleKey.Escape){
                keepGoing = false;
                break;
            }
        }

    }
    
}
