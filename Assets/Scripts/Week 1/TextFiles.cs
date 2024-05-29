using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TextFiles : MonoBehaviour
{

    //[SerializeField] private TextAsset characterInfo;
    [SerializeField] private string textFileName = "CharacterInfo.txt";
    private string textFileContents = string.Empty;


    // Start is called before the first frame update
    void Start()
    {
        GetTextFileContents();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetTextFileContents()
    {
        if (!string.IsNullOrEmpty(textFileName))
        {
            string filePath = Path.Combine(Application.streamingAssetsPath, textFileName);

            textFileContents = File.ReadAllText(filePath);

            Debug.Log(textFileContents);

            //string fileContents = File.ReadAllText(filePath);
            //characterInfo = new TextAsset(fileContents);
        }
    }

    void ParseCharacterInfo(string characterInfo)
    {
        string[] valuesFromText = characterInfo.Split(new char[] { ':', ',' }, System.StringSplitOptions.RemoveEmptyEntries);


    }
}
