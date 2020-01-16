using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    Text _text;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<Text>();
        timer = 30;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        Mathf.FloorToInt(timer);
        _text.text = timer.ToString("N1");
    }
}
