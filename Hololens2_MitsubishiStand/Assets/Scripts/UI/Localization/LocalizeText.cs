using System.Collections;
using System.Collections.Generic;
using MitsubishiAR.Model.Localization;
using TMPro;
using UnityEngine;

namespace MitsubishiAR.UI
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class LocalizeText : MonoBehaviour
    {
        [SerializeField] private string _key;
        [SerializeField] private bool _capitalize;

        private TextMeshProUGUI _text;

        private void Awake()
        {   
            _text = GetComponent<TextMeshProUGUI>();
            LocalizationManager.LM.OnLocaleChanged += OnLocaleChanged;
            Localize();
        }

        private void OnLocaleChanged()
        {
            Localize();
        }

        private void OnDestroy()
        {
            LocalizationManager.LM.OnLocaleChanged -= OnLocaleChanged;
        }

        private void Localize()
        {
            var localized = LocalizationManager.LM.Localize(_key);
            _text.text = _capitalize ? localized.ToUpper() : localized;
        }
    }

}
