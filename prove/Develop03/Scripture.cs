using Microsoft.VisualBasic;

class Scripture{
    //private static string _txt = "My God hath been my support he hath led me through mine afflictions in the wilderness and he hath preserved me upon the waters of the great deep He hath filled me with his love even unto the consuming of my flesh.";
    //private string[] _words= _txt.Split(" ");
    public static List<string>hiddenWords = new List<string>();
    public string[] Seperate(string verse){
        var words = verse.Split(" ");
        return words;
    }
    
}