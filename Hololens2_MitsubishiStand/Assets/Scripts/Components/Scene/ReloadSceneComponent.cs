using UnityEngine;
using UnityEngine.SceneManagement;

namespace MitsubishiAR.Components.Scene
{
    public class ReloadSceneComponent : MonoBehaviour
    {
        public void Reload()
        {
            var scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}

