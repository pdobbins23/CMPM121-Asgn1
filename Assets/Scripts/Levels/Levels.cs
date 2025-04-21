using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

[System.Serializable]
public class Level {
    public class Spawn{
        string enemy;
        
        string count;

        string hp;

        string delay;

        int[] sequence;

        string location;

    }

    public string name;
    public int waves;
    public Spawn[] spawns;
}
