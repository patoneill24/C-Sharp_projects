using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Word{

    private string hint;
    private int randomIndex;
    private bool keepRunning;
    public string Hide(string [] array){ 
            while(keepRunning == true){
                var random = new Random();
                randomIndex = random.Next(0, array.Length);
                if (array[randomIndex].Contains("_") == false){
                    randomIndex = random.Next(0, array.Length);
                    for(int i = 0; i<array[randomIndex].Length; i++){
                        hint += "_";
                    }
                //char [] characters = array[randomIndex].ToCharArray();
                }
                array[randomIndex] = hint;
                if (array[randomIndex].Contains("_")){
                    Scripture.hiddenWords.Add(array[randomIndex]);
                    keepRunning = false;
                    break;
                }
            }
        Scripture.hiddenWords.Add(array[randomIndex]);
        return array[randomIndex];
    }
}