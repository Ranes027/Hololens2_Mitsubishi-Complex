using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.UI.BoundsControl;

namespace MitubishiAR.Components
{
    public class ScalingStateComponent : MonoBehaviour
    {
        [SerializeField] private GameObject[] _objects;

        public void ChangeScalingState()
        {
            for (int i = 0; i < _objects.Length; i++)
            {
                EnableBoundsControl(_objects[i]);
                EnableObjectManipulator(_objects[i]);
            }
        }

        private void EnableBoundsControl(GameObject gameObject)
        {
            var bounds = gameObject.GetComponent<BoundsControl>();

            bounds.enabled = !bounds.enabled;
        }

        private void EnableObjectManipulator(GameObject gameObject)
        {
            var manipulator = gameObject.GetComponent<ObjectManipulator>();

            manipulator.enabled = !manipulator.enabled;
        }
    }
}

