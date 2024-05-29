using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(FileSystems))]
public class FileSystemCustomInspector : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        FileSystems fileSystemsScript = (FileSystems)target;

        if(GUILayout.Button("Open Persistant DataPath"))
        {
            fileSystemsScript.OpenPersistantDataPath();
        }
    }
}
