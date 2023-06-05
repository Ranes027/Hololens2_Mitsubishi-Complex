using UnityEngine;
using UnityEngine.Events;
using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using MitsubishiAR.Components.Scene;

namespace MitsubishiAR.Components.Object
{
    public class OverrideBoundsComponent : MonoBehaviour
    {
        [SerializeField] private GameObject _mainObject;
        [SerializeField] private GameObject _targetObject;

        public void OverrideBounds()
        {
            var obj = _mainObject.GetComponent<BoundsControl>();

            if (obj != null)
            {
                CheckMainObjectCollider();
                CheckOverridesState();

                obj.BoundsOverride = _targetObject.GetComponent<BoxCollider>();
            }
            else
            {
                Debug.Log("Can't find BoundsControl!");
            }
        }

        private void CheckMainObjectCollider()
        {
            var mainBox = _mainObject.GetComponent<BoxCollider>();

            if (mainBox.enabled == true)
            {
                mainBox.enabled = !mainBox.enabled;
            }
        }

        private void CheckOverridesState()
        {
            SceneConstants.Instance.SceneInfo.BoundsOverrides = !(_mainObject == _targetObject);
        }
    }
}

