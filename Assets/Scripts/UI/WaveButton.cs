using UnityEngine;
using TMPro;

public class WaveButton : MonoBehaviour
{
    public TextMeshProUGUI label;
    public string level;
    public EnemySpawner spawner;

    tmp = GetComponent<TextMeshProUGUI>();

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tmp.text = "Continue?";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartLevel(string text)
    {
        spawner.StartLevel(currentLevel);
    }
}
