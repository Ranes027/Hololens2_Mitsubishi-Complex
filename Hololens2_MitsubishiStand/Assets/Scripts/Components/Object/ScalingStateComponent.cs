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
                SwitchBoundsControlState(_objects[i]);
                SwitchObjectManipulatorState(_objects[i]);
                SwitchBoxColliderState(_objects[i]);
            }
        }

        private void SwitchBoundsControlState(GameObject gameObject)
        {
            var bounds = gameObject.GetComponent<BoundsControl>();

            bounds.enabled = !bounds.enabled;
        }

        private void SwitchObjectManipulatorState(GameObject gameObject)
        {
            var manipulator = gameObject.GetComponent<ObjectManipulator>();

            manipulator.enabled = !manipulator.enabled;
        }

        private void SwitchBoxColliderState(GameObject gameObject)
        {
            if (SceneConstants.Instance.SceneInfo.BoundsOverrides == false)
            {
                var box = gameObject.GetComponent<BoxCollider>();

                box.enabled = !box.enabled;
            }
        }
    }
}

