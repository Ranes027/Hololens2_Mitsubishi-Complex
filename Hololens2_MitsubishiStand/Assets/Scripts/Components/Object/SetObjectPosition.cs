using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjectPosition : MonoBehaviour
{
    [SerializeField] private Transform _startPosition;
    [SerializeField] private Transform _targetPosition;

    public void SetPosition()
    {
        var position = _startPosition.position;
        _targetPosition.position = position;
    }
}
