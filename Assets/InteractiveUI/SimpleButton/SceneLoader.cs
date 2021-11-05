using UnityEngine;
using UnityEngine.SceneManagement;

namespace InteractiveUI.SimpleButton
{
    public class SceneLoader : MonoBehaviour
    {
        public void LoadScene(int sceneIndex)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}