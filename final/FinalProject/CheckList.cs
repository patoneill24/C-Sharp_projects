public class CheckList{
    //gets track of total amount of points
    private int totalPoints;
    public int GetTotalPoints(){
        return totalPoints;
    }
    public void AddPoints(int value){
        totalPoints += value;
    }
}