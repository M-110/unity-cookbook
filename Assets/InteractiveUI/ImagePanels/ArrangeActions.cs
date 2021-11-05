using System;
using UnityEngine;

namespace InteractiveUI.ImagePanels
{
    public class ArrangeActions : MonoBehaviour
    {
        RectTransform panelRectTransform;
        void Awake()
        {
            panelRectTransform = GetComponent<RectTransform>();
        }

        public void MoveDownOne()
        {
            int currentSiblingIndex = panelRectTransform.GetSiblingIndex();
            panelRectTransform.SetSiblingIndex(Math.Max(currentSiblingIndex - 1, 0));
        }

        public void MoveUpOne()
        {
            int currentSiblingIndex = panelRectTransform.GetSiblingIndex();
            panelRectTransform.SetSiblingIndex(currentSiblingIndex + 1);
        }
    }
}
