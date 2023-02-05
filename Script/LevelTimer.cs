using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTimer : MonoBehaviour
{
    public static LevelTimer instance;
    public float levelTimer;

    void Awake(){
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        levelTimer = PlayerPrefs.GetFloat("levelTimer");
        Debug.Log(levelTimer);
    }

    // Update is called once per frame
    void Update()
    {
        levelTimer += Time.deltaTime;
    }

    public void SetLevelTimer(){
        PlayerPrefs.SetFloat("levelTimer", levelTimer);
    }
    public void ResetLevelTimer(){
        levelTimer = 0;
        SetLevelTimer();
    }
}
