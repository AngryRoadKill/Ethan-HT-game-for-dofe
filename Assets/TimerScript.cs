using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimerScript : MonoBehaviour
{
    private bool _timerActive;
    public float _currentTime { get; set; }
    public bool HasWon = false;
    // Start is called before the first frame update
    void Start()
    {
        _currentTime = 0;
        StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timerActive == true)
        {
            _currentTime = _currentTime + Time.deltaTime;
        }
        if (_currentTime > 22)
        {
            HasWon = true;
        }
    }
    public void StartTimer()
        { _timerActive = true; }
    public void StopTimer()
        { _timerActive = false; }
}
