using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI.CountdownTimer
{
    [RequireComponent(typeof (CountdownTimer))]
    public class DigitalCountdown : MonoBehaviour
    {
        [SerializeField] int timerLength = 10;
        Text clockText;
        CountdownTimer countdownTimer;

        void Awake()
        {
            clockText = GetComponent<Text>();
            countdownTimer = GetComponent<CountdownTimer>();
        }

        void Start()
        {
            countdownTimer.ResetTimer(timerLength);
        }

        void Update()
        {
            var timeRemaining = countdownTimer.GetSecondsRemaining();
            var message = TimerMessage(timeRemaining);
            clockText.text = message;
        }

        string TimerMessage(int timeRemaining)
        {
            if (timeRemaining <= 0)
                return "countdown has finished";
            return $"Countdown seconds remaining = {timeRemaining}";
        }
    }
}