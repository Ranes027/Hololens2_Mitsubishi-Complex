using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MitsubishiAR.Components.Object
{
    public class ObjectVisibilityManager : MonoBehaviour
    {
        [SerializeField] GameObject[] _objectsToShow;
        [SerializeField] GameObject[] _objectsToHide;

        public void ToggleObjectsVisibility()
        {
            // Show selected game objects
            foreach (GameObject objToShow in _objectsToShow)
            {
                objToShow.SetActive(true);
            }

            // Hide other game objects
            foreach (GameObject objToHide in _objectsToHide)
            {
                objToHide.SetActive(false);
            }
        }
    }

}
