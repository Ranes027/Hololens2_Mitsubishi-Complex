using System.Collections;
using System.Collections.Generic;
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

        [SerializeField] private UnityEvent _action;
        
        public void OverrideBounds()
        {
            var obj = _mainObject.GetComponent<BoundsControl>();

            if (obj != null)
            {
                CheckScalingState();
                CheckMainObjectCollider();
                CheckOverridesState();

                obj.BoundsOverride = _targetObject.GetComponent<BoxCollider>();
            }
            else
            {
                Debug.Log("Can't find BoundsControl!");
            }
        }

        private void CheckScalingState()
        {   
            var bounds = _mainObject.GetComponent<BoundsControl>();

            if(bounds.enabled == true)
            {
                _action?.Invoke();
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
            if (_mainObject == _targetObject)
            {
                SceneConstants.Instance.SceneInfo.BoundsOverrides = false;
            }
            else
            {
                SceneConstants.Instance.SceneInfo.BoundsOverrides = true;
            }
        }
    }
}

