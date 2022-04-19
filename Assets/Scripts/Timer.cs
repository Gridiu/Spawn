using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    private const float TimerMinValue = 0f;
    private const float TimerMaxValue = 2f;

    [SerializeField] private UnityEvent _timerReset;

    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= TimerMaxValue)
        {
            _timer = TimerMinValue;

            _timerReset.Invoke();

            Debug.Log(Time.time);
        }         
    }
}
