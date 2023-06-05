using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

namespace MitsubishiAR.Components.Object.States
{
    public class ToolTipsStateComponent : SwitchComponentState
    {
        [SerializeField] private GameObject[] _objects;

        public void ChangeToolTipState()
        {
            for (int i = 0; i < _objects.Length; i++)
            {
                SwitchState<ToolTipSpawner>(_objects[i]);
            }
        }
    }
}

