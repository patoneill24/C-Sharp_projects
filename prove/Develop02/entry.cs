namespace JournalApp;
using System.Net;

public class Entry{
    public string response;
    public string prompt;
    public Entry(string response, string prompt, string date){
        this.response = response;
        this.prompt = prompt;
        this.date = date;
    }
    public Entry(){
        
    }
    public Entry(string import){
        var parts = import.Split("|");
        this.date = parts[0];
        this.prompt = parts[1];
        this.response = parts[2];
    }

    public string Export(){
        return $"{date}|{prompt}|{response}";
    }

    public string Display(){
        return $"Date: {date} - Prompt: {prompt}\n{response}\n";
    }
    public string date;
    public string GetPrompt()
    {
        Random rnd = new Random();

        int myRandomNumber;

        List<string> prompts = new List<string>(){
            "What was the best part of your day?",
            "If you could do one thing differently, what would it be?",
            "How have you seen the hand of the Lord in your life today?",
            "What was the strongest emotion you felt today?",
            "What was the most interesting thing you learned today?",
            "What was the hardest thing you experienced today?"
        };

        myRandomNumber = rnd.Next(0,prompts.Count);

        return prompts[myRandomNumber];


    }

}