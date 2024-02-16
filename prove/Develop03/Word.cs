using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Word{
    private string hint;
    private int randomIndex;
    private int sumOfHiddenWords;
    public string Hide(string [] array){ 
        var random = new Random();
        randomIndex = random.Next(0,array.Length);
        if (array[randomIndex].Contains('_')){
            foreach(string word in array){
                if(word.Contains('_')){
                    sumOfHiddenWords += 1;
                }
            }
            while(array[randomIndex].Contains('_')){
                if (sumOfHiddenWords == array.Length){
                    break;
                }
                random = new Random();
                randomIndex = random.Next(0,array.Length);
                if (array[randomIndex].Contains('_')==false){
                    break;
                }
            }
        }
        for(int i = 0; i<array[randomIndex].Length; i++){
            hint+="_";
        }
        if (sumOfHiddenWords == array.Length){
            return null;
        }
        array[randomIndex] = hint;   
        Scripture.hiddenWords.Add(array[randomIndex]);
        return array[randomIndex];
    }
}