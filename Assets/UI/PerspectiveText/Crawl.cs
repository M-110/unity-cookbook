using UnityEngine;

namespace UI.PerspectiveText
{
    public class Crawl : MonoBehaviour
    {
        [SerializeField] float crawlSpeed = 20;

        void Update()
        {
            transform.position += transform.up * (crawlSpeed * Time.deltaTime);
        }
    }
}