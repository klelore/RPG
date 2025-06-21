using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GC : MonoBehaviour
{


    public GameObject start;
    public GameObject b;
    public GameObject c;
    public GameObject d;

    private bool isPaused = false;
    // Start is called before the first frame update
    private void Awake()
    {
        Time.timeScale = 0f;

    }
    void Start()
    {

    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            TogglePause();
        }
    }
    public void StartPause()
    {

        Time.timeScale = 1f;
    }
    public void TogglePause()
    {
        isPaused = !isPaused;

        // 时间缩放为0表示暂停，1表示正常速度
        Time.timeScale = isPaused ? 0f : 1f;

    }

    public void HideStart()
    {
        start.SetActive(false);
    }
}
