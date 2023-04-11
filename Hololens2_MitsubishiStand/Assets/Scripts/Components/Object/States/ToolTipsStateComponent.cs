using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

namespace MitsubishiAR.Components.Object.States
{
    public class ToolTipsStateComponent : MonoBehaviour
    {
        [SerializeField] private GameObject[] _objects;

        public void ChangeToolTipState()
        {
            for (int i = 0; i < _objects.Length; i++)
            {
                EnableToolTip(_objects[i]);
            }
        }

        private void EnableToolTip(GameObject gameObject)
        {
            var toolTip = gameObject.GetComponent<ToolTipSpawner>();

            toolTip.enabled = !toolTip.enabled;
        }
    }
}

