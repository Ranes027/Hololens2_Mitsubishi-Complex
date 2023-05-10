using UnityEngine;

namespace MitsubishiAR.Components.Scene
{
    [System.Serializable]
    public class SceneInfo
    {
        public bool BoundsOverrides;
    }

    public class SceneConstants : MonoBehaviour
    {
        public SceneInfo SceneInfo;

        public static SceneConstants Instance;

        private void Awake()
        {
            if (Instance == null)
            {
                transform.parent = null;
                DontDestroyOnLoad(gameObject);

                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
