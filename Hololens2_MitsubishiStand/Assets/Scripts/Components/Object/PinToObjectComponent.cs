using UnityEngine;

namespace MitsubishiAR.Components.Object
{
    public class PinToObjectComponent : MonoBehaviour
    {
        [SerializeField] private Transform[] _objects;
        [SerializeField] private Transform _parent;

        private bool _isPinned = true;

        public void ChangePinState()
        {
            if (_isPinned == true)
            {
                UnpinObjects(_objects);
                _isPinned = false;
            }
            else
            {
                PinObjects(_objects, _parent);
                _isPinned = true;
            }
        }

        private void UnpinObjects(Transform[] objects)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].parent = null;
            }
        }

        private void PinObjects(Transform[] objects, Transform parent)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].SetParent(parent.transform);
            }
        }
    }
}
