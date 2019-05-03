using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public int time = 5;
    private int clicks = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Timer");
    }

    // Update is called once per frame
    void Update()
    {
      if(time <= 0) { 

      }
    }

    private void OnMouseDown()
    {
        if(time > 0)
        {
            clicks++;
        }

    }

    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.normal.textColor = Color.red;
        string l1 = "Score: " + clicks;
        string l2 = "Timer: " + time;

        if (time <= 0) {
            l1 = "Score: " + clicks;
            l2 = "Timer: TIMEOVER";
        } 

        GUI.Label(new Rect(10, 10, 140, 20), l1, style);
        GUI.Label(new Rect(10, 40, 140, 20), l2, style);

    }

    IEnumerator Timer() {
        yield return new WaitForSeconds(1);
        time--;
        StartCoroutine("Timer");
    }
}
