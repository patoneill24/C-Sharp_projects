using Microsoft.VisualBasic;

class Scripture{
    public static List<string>hiddenWords = new List<string>();
    public string[] Seperate(string verse){
        var words = verse.Split(" ");
        return words;
    }
    
}