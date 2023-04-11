using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace MitsubishiAR.Components.Animations
{
    public class ActionController : MonoBehaviour
    {
        [SerializeField] private UnityEvent[] _onEnterAnimation;

        public void Action(int actionNumber)
        {   
            _onEnterAnimation[actionNumber]?.Invoke();
        }
    }
}

