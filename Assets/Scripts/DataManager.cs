using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : Singleton<DataManager> {
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HighScore() {
        if (GameManager.Instance.points > PlayerPrefs.GetInt("HighScore", 0)) {
            PlayerPrefs.SetInt("HighScore", GameManager.Instance.points);
        }
    }

    public int LoadScore() {
        return PlayerPrefs.GetInt("HighScore");
    }
}
