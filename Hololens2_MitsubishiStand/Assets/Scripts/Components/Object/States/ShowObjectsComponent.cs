using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitsubishiAR.Components.Object.States
{
    public class ShowObjectsComponent : MonoBehaviour
    {
        [SerializeField] private GameObject[] _objects;

        public void Show()
        {
            for (int i = 0; i < _objects.Length; i++)
            {
                _objects[i].SetActive(true);
            }
        }
    }
}
