using UnityEngine;

namespace MitsubishiAR.Components.Object.States
{
    public abstract class SwitchComponentState : MonoBehaviour
    {
        public static void SwitchState<T>(GameObject gameObject) where T : MonoBehaviour
        {
            var component = gameObject.GetComponent<T>();
            if (component != null)
            {
                component.enabled = !component.enabled;
            }
            else
            {
                Debug.Log($"Add {typeof(T).Name} to object!");
            }
        }

        public static void SwitchState<T>(GameObject gameObject, bool state) where T : MonoBehaviour
        {
            var component = gameObject.GetComponent<T>();
            if (component != null)
            {
                component.enabled = state;
            }
            else
            {
                Debug.Log($"Add {typeof(T).Name} to object!");
            }
        }

        public static void SwitchColliderState<T>(GameObject gameObject) where T : Collider
        {
            var component = gameObject.GetComponent<T>();
            if (component != null)
            {
                component.enabled = !component.enabled;
            }
            else
            {
                Debug.Log($"Add {typeof(T).Name} to object!");
            }
        }

        public static void SwitchRendererState<T>(GameObject gameObject) where T : Renderer
        {
            var component = gameObject.GetComponent<T>();
            if (component != null)
            {
                component.enabled = !component.enabled;
            }
            else
            {
                Debug.Log($"Add {typeof(T).Name} to object!");
            }
        }

        public static void SwitchRendererState<T>(GameObject gameObject, bool state) where T : Renderer
        {
            var component = gameObject.GetComponent<T>();
            if (component != null)
            {
                component.enabled = state;
            }
            else
            {
                Debug.Log($"Add {typeof(T).Name} to object!");
            }
        }
    }
}
