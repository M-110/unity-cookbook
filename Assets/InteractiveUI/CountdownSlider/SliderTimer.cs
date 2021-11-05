using System;
using UnityEngine;
using UnityEngine.UI;

namespace InteractiveUI.CountdownSlider
{
    public class SliderTimer : MonoBehaviour
    {
        [SerializeField] int countdownLength;
        [SerializeField] Slider slider;
        Text text;
        float timeLeft;

        void Awake() => text = GetComponent<Text>();

        void Start() => timeLeft = countdownLength;

        void Update()
        {
            if (timeLeft < 0) return;
            
            timeLeft -= Time.deltaTime;
            text.text = Mathf.RoundToInt(timeLeft).ToString();
            slider.value = 1 - timeLeft / countdownLength;
        }
    }
}
