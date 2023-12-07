using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameTimer : MonoBehaviour
{
    private MeshRenderer boxMesh;

    float time = 1.0f;
    public Text TimerText;
    private float timerTime = 30f;
    internal static int GetTimerTime;

    // Start is called before the first frame update
    void Start()
    {
        boxMesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerTime < 0)
        
            TimerText.text = "0";
        else
            {
                TimerText.text = $" {timerTime -= Time.deltaTime}";
            }
        }
    }
    // Timer Text. text = $" [(timerTime -= Time, deltaTime). ToString ("F2")]";