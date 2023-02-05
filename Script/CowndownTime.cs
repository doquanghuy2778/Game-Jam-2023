using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CowndownTime : MonoBehaviour
{
    public static CowndownTime ins;
    private bool isCheck;

    [SerializeField] private float currTime;
    [SerializeField] private float startTime;
    [SerializeField] private TextMeshProUGUI meshPro;

    private void Awake()
    {
        ins = this;
    }
    void Start()
    {
        currTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCheck)
        {
            CheckCowndownTime();
        }

        //PlayerPrefs.SetInt("Bien can goi", value);

        //int t = PlayerPrefs.GetInt("Bien can goi");
    }
    void CheckCowndownTime()
    {
        meshPro.enabled = true;
        currTime -= 1 * Time.deltaTime;
        meshPro.text = currTime.ToString("0");
        if (currTime <= 0)
        {
            currTime = 0;
            meshPro.enabled = false;
        }
    }

    public void ActiveCoutdownEvent()
    {
        isCheck = true;
    }
}
