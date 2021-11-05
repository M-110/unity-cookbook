using System;
using UnityEngine;
using UnityEngine.UI;

namespace InteractiveUI.InteractiveSlider
{
    public class SliderValueToText : MonoBehaviour
    {
        [SerializeField] Slider sliderUI;
        Text textSliderValue;
        void Awake() => textSliderValue = GetComponent<Text>();

        void Start() => ShowSliderValue();

        public void ShowSliderValue()
        {
            textSliderValue.text = $"Slider value = {sliderUI.value}";
        }
    }
}
