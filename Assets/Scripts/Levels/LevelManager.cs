using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class LevelManager{
    private List<Level> LevelData;
    private static LevelManager theInstance;
    public static LevelManager Instance {  get
        {
            if (theInstance == null)
                theInstance = new LevelManager();
            return theInstance;
        }
    }

    private LevelManager(){
        TextAsset jsonFile = Resources.Load<TextAsset>("levels.json");
        LevelData = JsonUtility.FromJson<List<Level>>(jsonFile.text);
        Debug.Log(LevelData);
    }
}
