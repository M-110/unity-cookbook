using UnityEngine;
using UnityEngine.UI;
using System;

namespace UI.DigitalClock
{
    public class DigitalClock : MonoBehaviour
    {
        Text clockText;
        [SerializeField] bool useAlternative;

        void Awake()
        {
            clockText = GetComponent<Text>();
        }

        void Update()
        {
            if (useAlternative)
                UpdateClock();
            else
                UpdateClock2();
        }

        void UpdateClock()
        {
            var time = DateTime.Now;
            var hour = LeadingZero(time.Hour);
            var minute = LeadingZero(time.Minute);
            var second = LeadingZero(time.Second);

            clockText.text = $"{hour}:{minute}:{second}";
        }

        void UpdateClock2()
        {
            clockText.text = DateTime.Now.ToLongTimeString();
        }

        static string LeadingZero(int num)
        {
            return num.ToString().PadLeft(2, '0');
        }
    }
}