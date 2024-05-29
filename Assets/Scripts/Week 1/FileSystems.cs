using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class FileSystems : MonoBehaviour
{

    public string MyName;
    // Start is called before the first frame update
    void Start()
    {

        // Relative Path
        // Assets/Scripts/FileSystems.cs

        //Absoulte Path
        // c:/UnityProjects/MyProject/Assets/Scripts/FileSystems.cs
        // "c:/UnityProjects/MyProject/Assets/Scripts/" + "FileSystems.cs"

        string assestPath = Application.dataPath;
        Debug.Log("Asset Path: " + assestPath);

        Directory.CreateDirectory(assestPath + "/MyFolder");

        string persistantPath = Application.persistentDataPath;
        Debug.Log("Persistant data Path: " + persistantPath);

        string streamingAssetsPath = Application.streamingAssetsPath;

        if (Directory.Exists(streamingAssetsPath))
        {
            Debug.Log("StreamingAssetsPath: " + streamingAssetsPath);
        }
        else
        {
            Directory.CreateDirectory(Path.Combine(Application.dataPath, "StreamingAssets"));
            Debug.Log("StreamingAssetsPath: " + streamingAssetsPath);
        }

        if(File.Exists(Path.Combine(Application.streamingAssetsPath, "PlayerInfo.txt")))
        {
            Debug.Log("Yay text file exists.");
        }
        else
        {
            File.CreateText(Path.Combine(Application.streamingAssetsPath, "PlayerInfo.txt"));
            Debug.Log("Yay text file exists.");
        }

        string[] allFiles = Directory.GetFiles(Application.streamingAssetsPath);

        for (int i = 0;  i < allFiles.Length; i++)
        {
            Debug.Log(allFiles[i]);
        }

        


        string temporaryChahePath = Application.temporaryCachePath;
        Debug.Log("Temporary Cache Path: " + temporaryChahePath);

        Application.OpenURL(temporaryChahePath);

        string editorPath = "Assets/Editor/";
        Debug.Log("Editor Path: " + editorPath);

        string resourcesPath = "Assets/Resources/";
        Debug.Log("Resorces Path: " + resourcesPath);
        Object gunPrefab = Resources.Load("gun.prefab");

        string filePath = Path.Combine(Application.dataPath, "example.txt");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Open Persistant Datapath")]
    public void OpenPersistantDataPath()
    {
        string persistantPath = Application.persistentDataPath;
        Application.OpenURL (persistantPath);
    }

    [MenuItem("Window/Open Persistant Datapath")]
    public static void WindowPersistantDataPath()
    {
        string persistantPath = Application.persistentDataPath;
        Application.OpenURL (persistantPath);
    }
}

   
