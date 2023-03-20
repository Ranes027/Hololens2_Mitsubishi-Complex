using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI.BoundsControl;

namespace MitubishiAR.Components
{
    public class OverrideBoundsComponent : MonoBehaviour
    {
        [SerializeField] private GameObject _mainObject;
        [SerializeField] private GameObject _targetObject;

        public void OverrideBounds()
        {
            var obj = _mainObject.GetComponent<BoundsControl>();
            var box = _mainObject.GetComponent<BoxCollider>();

            if (obj != null)
            {
                if(box.enabled == true)
                {
                    box.enabled = !box.enabled;
                }
                
                obj.BoundsOverride = _targetObject.GetComponent<BoxCollider>();
            }
            else
            {
                Debug.Log("Can't find BoundsControl!");
            }
        }
    }
}

