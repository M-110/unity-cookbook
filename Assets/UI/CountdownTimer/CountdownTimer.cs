using System;
using UnityEngine;

namespace UI.CountdownTimer
{
    public class CountdownTimer : MonoBehaviour
    {
        float timeLeft;

        public void Update()
        {
            timeLeft -= Time.deltaTime;
        }

        public void ResetTimer(int timerLength)
        {
            timeLeft = timerLength;
        }

        public int GetSecondsRemaining()
        {
            return (int) timeLeft;
        }

        public float GetExactTimeRemaining()
        {
            return timeLeft;
        }
    }
}