using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
[System.Serializable]

public class Levels {
    string name;

    int waves;

    public class Spawn{
        string enemy;
        
        string count;

        string hp;

        string delay;

        int[] sequence;

        string location;

    }
    Spawn[] spawns;
}