using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitsubishiAR.Components.Object
{
    public class ScaleObjectsComponent : MonoBehaviour
    {
        [SerializeField] private GameObject[] _objects;
        [Header("Scale Parameters")]
        [SerializeField] private float _xScale = 1;
        [SerializeField] private float _yScale = 1;
        [SerializeField] private float _zScale = 1;

        public void ScaleObjects()
        {
            for (int i = 0; i < _objects.Length; i++)
            {
                if (_objects[i] != null)
                {
                    _objects[i].transform.localScale = new Vector3(_xScale, _yScale, _zScale);
                }
            }
        }
    }

}
