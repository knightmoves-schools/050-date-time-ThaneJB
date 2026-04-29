using System.Text;

namespace knightmoves;

public class Printer{
    
    public string Print(string dateString){
        DateTime date = DateTime.Parse(dateString);
        return ($"{date}");
    }
} 