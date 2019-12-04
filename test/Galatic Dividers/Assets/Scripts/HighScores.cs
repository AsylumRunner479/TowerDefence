using System.Xml.Serialization;
[System.Serializable]

public class HighScores
{
    [XmlAttribute("Names")]
    public string[] playerName = new string[1] {"Blank"};
    [XmlAttribute("highScore")]
    public int[] highScore = new int[1] {0};

}
