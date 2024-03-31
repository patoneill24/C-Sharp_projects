public class CheckList{
    private int totalPoints;
    public int GetTotalPoints(){
        return totalPoints;
    }
    public void AddPoints(int value){
        totalPoints += value;
    }
}