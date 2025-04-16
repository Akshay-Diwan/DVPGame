using System.IO;
using UnityEngine;

public class CSVWriter : MonoBehaviour
{
    string filePath;

    void Start(){
        filePath = Path.Combine(Application.persistentDataPath, "myData.csv");
        WriteToCSV("Name,Score,Time");
        WriteToCSV("Alice,90,00:02:15");
        WriteToCSV("Bob,75,00:03:45");
    }
   void WriteToCSV(string line){
    using (StreamWriter sw = new StreamWriter(filePath, true)){
        sw.WriteLine(line);

    }
    Debug.Log("Written to: "+ filePath);
}
}
