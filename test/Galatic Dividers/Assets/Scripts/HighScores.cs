using System.Xml.Serialization;
[System.Serializable]

public class HighScores
{
    [XmlArray("Names")]
    public string[] playerName = new string[1] {"Blank"};
    [XmlElement("highScore")]
    public float highScore;

}
