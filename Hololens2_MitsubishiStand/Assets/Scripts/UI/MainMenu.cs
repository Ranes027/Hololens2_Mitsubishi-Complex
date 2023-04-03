using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitsubishiAR.UI
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField] private GameObject _general;
        [SerializeField] private GameObject _login;
        [SerializeField] private GameObject _settings;

        [SerializeField] private GameObject _backButton;

        public void Login()
        {
            SubMenuSwitch(_settings, _login);
        }

        public void Settings()
        {
            SubMenuSwitch(_login, _settings);
        }

        public void Back()
        {
            _general.SetActive(true);
            _login.SetActive(false);
            _settings.SetActive(false);
            _backButton.SetActive(false);
        }

        private void SubMenuSwitch(GameObject _menuToCheck, GameObject _targetMenu)
        {
            if (_menuToCheck.activeSelf == false)
            {
                GameObject[] _objects = { _general, _targetMenu, _backButton };
                ChangeState(_objects);
            }
            else
            {
                GameObject[] _objects = { _menuToCheck, _targetMenu };
                ChangeState(_objects);
            }
        }

        private void ChangeState(GameObject[] objects)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i].activeSelf == true)
                {
                    objects[i].SetActive(false);
                }
                else
                {
                    objects[i].SetActive(true);
                }
            }

        }
    }

}
