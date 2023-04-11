using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MitsubishiAR.Components.Scene
{
    public class LoadSceneComponent : MonoBehaviour
    {        
        public void LoadLevel(string sceneName)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
    }
}


