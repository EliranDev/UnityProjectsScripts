﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSystem : MonoBehaviour
{
    public float countTime = 0;
    public Text textBox;

    // Start is called before the first frame update
    void Start()
    {
        textBox.text = countTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;
        textBox.text = Mathf.Round(countTime).ToString();
    }
}
