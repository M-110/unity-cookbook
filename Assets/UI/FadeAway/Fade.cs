using UnityEngine;
using UI.CountdownTimer;
using UnityEngine.UI;

namespace UI.FadeAway
{
    [RequireComponent(typeof (CountdownTimer.CountdownTimer))]
    public class Fade : MonoBehaviour
    {
        CountdownTimer.CountdownTimer countdownTimer;
        Text text;

        void Awake()
        {
            text = GetComponent<Text>();
            countdownTimer = GetComponent<CountdownTimer.CountdownTimer>();
        }

        void Start()
        {
            countdownTimer.ResetTimer(5);
        }

        void Update()
        {
            var alphaRemaining = countdownTimer.GetExactTimeRemaining();
            var textColor = text.color;
            textColor.a = alphaRemaining / 5;
            text.color = textColor;
        }
    }
}