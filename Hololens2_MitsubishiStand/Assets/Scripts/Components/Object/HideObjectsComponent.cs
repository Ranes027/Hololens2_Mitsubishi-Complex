using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitubishiAR.Components
{
    public class HideObjectsComponent : MonoBehaviour
    {
        [SerializeField] private GameObject[] _objects;

        public void Hide()
        {
            for (int i = 0; i < _objects.Length; i++)
            {
                _objects[i].SetActive(false);
            }
        }
    }
}
