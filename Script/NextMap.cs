using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class NextMap : MonoBehaviour
{
    private LevelTimer levelTimerInstance;
    [SerializeField] private Button nextMapButton;
    [SerializeField] private TextMeshProUGUI levelCompleteText;

    // Start is called before the first frame update
    void Start()
    {
        levelTimerInstance = LevelTimer.instance;
        // nextMapButton = GetComponent<Button>();
        nextMapButton.onClick.AddListener(GetNextMap);
        gameObject.SetActive(false);
    }

    void GetNextMap(){
        Debug.Log("next map");
        levelTimerInstance.ResetLevelTimer();
        NextScene();
    }

    void NextScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int nextScene = currentScene + 1;
        if (nextScene == SceneManager.sceneCountInBuildSettings)
        {
            nextScene = 0;
        }
        SceneManager.LoadScene(nextScene);
    }

    public void SetText(){
        string levelTimerString = TimeSpan.FromSeconds(levelTimerInstance.levelTimer).ToString("mm\\:ss\\.fff");
        levelCompleteText.text = string.Format("Level completed ({0})", levelTimerString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
