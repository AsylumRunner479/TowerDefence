using System.Xml.Serialization;
[System.Serializable]

public class HighScores
{
    [XmlAttribute("Names")]
    public string[] playerName = new string[10] { "Blank", "Blank", "Blank", "Blank", "Blank", "Blank", "Blank", "Blank", "Blank", "Blank"};
    [XmlAttribute("highScore")]
    public int[] highScore = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

}
