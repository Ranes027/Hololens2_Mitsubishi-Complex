using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using MitsubishiAR.Components.Scene;

namespace MitsubishiAR.Components.Object.States
{
    public class ScalingStateComponent : MonoBehaviour
    {
        [SerializeField] private GameObject[] _objects;
        [SerializeField] private bool _needToSwitchBoxState;

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

            if (bounds == null)
            {
                var boundBox = gameObject.GetComponent<BoundingBox>();
                boundBox.enabled = !boundBox.enabled;
            }
            else
            {
                bounds.enabled = !bounds.enabled;
            }
        }

        private void SwitchObjectManipulatorState(GameObject gameObject)
        {
            var manipulator = gameObject.GetComponent<ObjectManipulator>();

            manipulator.enabled = !manipulator.enabled;
        }

        private void SwitchBoxColliderState(GameObject gameObject)
        {

            if (SceneConstants.Instance.SceneInfo.BoundsOverrides == false && _needToSwitchBoxState)
            {
                var box = gameObject.GetComponent<BoxCollider>();

                box.enabled = !box.enabled;
            }
        }
    }
}

