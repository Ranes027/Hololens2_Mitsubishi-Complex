using System.Collections.Generic;
using MitsubishiAR.Model.Data;
using MitsubishiAR.Model.Localization;
using UnityEngine;

namespace MitsubishiAR.UI
{
    public class SettingsWindow : MonoBehaviour
    {
        [SerializeField] private Transform _container;
        [SerializeField] private LocaleItemWidget _prefab;

        private DataGroup<LocaleInfo, LocaleItemWidget> _dataGroup;

        private readonly string[] _supportedLocales = new[] { "ru", "en" };

        private void Start()
        {
            _dataGroup = new DataGroup<LocaleInfo, LocaleItemWidget>(_prefab, _container);
            _dataGroup.SetData(ComposeData());
        }

        private List<LocaleInfo> ComposeData()
        {
            var data = new List<LocaleInfo>();
            foreach (var locale in _supportedLocales)
            {
                data.Add(new LocaleInfo { LocaleId = locale });
            }
            return data;
        }

        public void OnSelected(string selectedLocale)
        {
            LocalizationManager.LM.SetLocale(selectedLocale);
        }
    }
}


