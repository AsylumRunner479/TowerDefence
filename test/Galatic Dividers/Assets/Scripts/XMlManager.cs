using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Xml;
using System.Xml.Serialization;
using System.IO;

public static class XMIManager
{
    public static string path = Application.persistentDataPath + "/" + "High.xml";
    public static HighScores ReadData()
    {
        if (File.Exists(path))
        {
            var serializer = new XmlSerializer(typeof(HighScores));
            var stream = new FileStream(path, FileMode.Open);
            var container = serializer.Deserialize(stream) as HighScores;
            stream.Close();
            return container;
        }
        else
        {
            return null;
        }
    }
    public static void WriteData(HighScores data)
    {
        var serializer = new XmlSerializer(typeof(HighScores));
        var stream = new FileStream(path, FileMode.Create);
        serializer.Serialize(stream, data);
        stream.Close();
    }
}