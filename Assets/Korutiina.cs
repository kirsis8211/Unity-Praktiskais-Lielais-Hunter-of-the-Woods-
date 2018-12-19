using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Korutiina : MonoBehaviour
{
    Rect fpsRect;
    GUIStyle Style;
    float fps;

    void Start()
    {

        fpsRect = new Rect(100, 100, 600, 100);
        Style = new GUIStyle();
        Style.fontSize = 20;
        Style.normal.textColor = Color.red;
        StartCoroutine(FPSCalc());
    }

  private IEnumerator FPSCalc()
    {
        while (true)
        {
            fps = 1 / Time.deltaTime;
            yield return new WaitForSeconds(1);
        }
    }


    void OnGUI()
    {
        float fps = 1 / Time.deltaTime;
        GUI.Label(fpsRect, "FPS:" + fps, Style);

    }
}