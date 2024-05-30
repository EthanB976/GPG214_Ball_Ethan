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
        ParseCharacterInfo(textFileContents);
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

        if(valuesFromText.Length % 2 != 0)
        {
            // there are uneven number of entries
            Debug.LogError("Something went wrong parsing the data, there is uneven amount of entries");
            return;
        }

        Dictionary<string, string> characterInfoDictionary = new Dictionary<string, string>();

        for(int i = 0; i < valuesFromText.Length; i += 2)
        {
            string currentKey = valuesFromText[i].Trim();
            string currentValue = valuesFromText[i + i].Trim();
            Debug.Log(currentValue);

            characterInfoDictionary.Add(currentKey, currentValue);
        }

        foreach(KeyValuePair<string, string> pair in characterInfoDictionary)
        {
            Debug.Log("Key: " + pair.Key + " Value: " + pair.Value);
        }

    }
}
