using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class EnemyManager{
    private List<Enemy> EnemyData;
    private static EnemyManager theInstance;
    public static EnemyManager Instance {  get
        {
            if (theInstance == null)
                theInstance = new EnemyManager();
            return theInstance;
        }
    }

    private EnemyManager(){
        TextAsset jsonFile = Resources.Load<TextAsset>("enemies.json");
        EnemyData = JsonUtility.FromJson<List<Enemy>>(jsonFile.text);
        Debug.Log(EnemyData);
    }
}

