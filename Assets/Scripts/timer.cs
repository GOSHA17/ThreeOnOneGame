using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float maxTime;
    public GameObject NextPanel;
    private float time;
    private Image Timer;
    // Start is called before the first frame update
    void Start()
    {
        Timer = GetComponent<Image>();
        time = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (time>0)
        {
            time = Mathf.Clamp(time-Time.deltaTime,0,maxTime);
            Timer.fillAmount = time/maxTime;
            if (time==0)
            {
                gameObject.SetActive(false);
                NextPanel.SetActive(true);
            }
        }
    }
}
