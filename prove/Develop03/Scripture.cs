using Microsoft.VisualBasic;

class Scripture{
    public string[] Seperate(string verse){
        var words = verse.Split(" ");
        return words;
    }
    
}