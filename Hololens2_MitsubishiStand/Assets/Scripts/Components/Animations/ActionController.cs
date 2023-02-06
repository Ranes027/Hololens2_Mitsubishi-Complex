using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace MitubishiAR.Components
{
    public class ActionController : MonoBehaviour
    {
        [SerializeField] private UnityEvent _onEnterAnimation;

        public void Action()
        {
            _onEnterAnimation?.Invoke();
        }
    }
}

