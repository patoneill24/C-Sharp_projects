using System.ComponentModel.DataAnnotations;

class Refrence{
    private string _book;
    private string _chapter;
    private string _verseNumber;
    private string _verse;
    public Refrence(string verseNumber){
        _book = "2 Nephi";
        _chapter = "4";
        _verseNumber = verseNumber;
        _verse = "My God hath been my support he hath led me through mine afflictions in the wilderness and he hath preserved me upon the waters of the great deep";
    }

    public Refrence(string verseNumber, string verseNumberEnd){
        _book = "2 Nephi";
        _chapter = "4";
        _verseNumber = $"{verseNumber}-{verseNumberEnd}";
        _verse = "My God hath been my support he hath led me through mine afflictions in the wilderness and he hath preserved me upon the waters of the great deep He hath filled me with his love even unto the consuming of my flesh";
    }

    public string Display(){
        return $"{_book} {_chapter}:{_verseNumber} ";
    }

    public string GetVerse(){
        return _verse;
    }

}