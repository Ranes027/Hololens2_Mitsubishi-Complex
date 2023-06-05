using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using MitsubishiAR.Components.Scene;

namespace MitsubishiAR.Components.Object.States
{
    public class ScalingStateComponent : SwitchComponentState
    {
        [SerializeField] private GameObject[] _objects;
        [SerializeField] private bool _needToSwitchBoxState;

        public void ChangeScalingState()
        {
            for (int i = 0; i < _objects.Length; i++)
            {
                SwitchState<BoundsControl>(_objects[i]);
                SwitchState<ObjectManipulator>(_objects[i]);

                if (SceneConstants.Instance.SceneInfo.BoundsOverrides == false && _needToSwitchBoxState)
                {
                    SwitchColliderState<BoxCollider>(_objects[i]);
                }
            }
        }

        public static void ChangeScalingState(GameObject[] objects)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                SwitchState<BoundsControl>(objects[i]);
                SwitchState<ObjectManipulator>(objects[i]);
            }
        }

        public static void ChangeScalingState(GameObject[] objects, bool state)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                SwitchState<BoundsControl>(objects[i], state);
                SwitchState<ObjectManipulator>(objects[i], state);
            }
        }
    }
}

