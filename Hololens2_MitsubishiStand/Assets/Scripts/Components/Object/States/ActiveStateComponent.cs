using UnityEngine;

namespace MitsubishiAR.Components.Object.States
{
    public class ActiveStateComponent : MonoBehaviour
    {
        [SerializeField] private GameObject[] _objects;

        public void SwitchActiveCondition()
        {
            foreach (var obj in _objects)
            {
                obj.SetActive(!obj.activeSelf);
            }
        }

        public void SwitchActiveCondition(bool state)
        {
            foreach (var obj in _objects)
            {
                obj.SetActive(state);
            }
        }

        public static void SwitchActiveCondition(GameObject gameObject)
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }

        public static void SwitchActiveCondition(GameObject gameObject, bool state)
        {
            gameObject.SetActive(state);
        }

        public static void SwitchActiveCondition(GameObject[] gameObjects)
        {
            foreach (var obj in gameObjects)
            {
                obj.SetActive(!obj.activeSelf);
            }
        }

        public static void SwitchActiveCondition(GameObject[] gameObjects, bool state)
        {
            foreach (var obj in gameObjects)
            {
                obj.SetActive(state);
            }
        }
    }
}

