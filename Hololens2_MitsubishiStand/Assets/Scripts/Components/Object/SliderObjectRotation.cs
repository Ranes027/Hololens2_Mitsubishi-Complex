using UnityEngine;
using UnityEngine.UI;

namespace MitsubishiAR.Components.Object
{
    public class SliderObjectRotation : MonoBehaviour
    {
        [SerializeField] private Slider _slider;
        [SerializeField] private float _xAngleLimit = 180f;
        [SerializeField] private float _yAngleLimit = 180f;
        [SerializeField] private float _zAngleLimit = 180f;

        void Start()
        {
            _slider.onValueChanged.AddListener(delegate
            {
                RotateMe();
            });
        }

        public void RotateMe()
        {
            transform.localEulerAngles = new Vector3(_slider.value * _xAngleLimit, _slider.value * _yAngleLimit, _slider.value * _zAngleLimit);
        }
    }

}

