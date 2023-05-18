using MitsubishiAR.Model.Localization;
using Microsoft.MixedReality.Toolkit.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MitsubishiAR.UI
{
    public class LocalizeText : MonoBehaviour
    {
        [SerializeField] private TextType _textType;
        [SerializeField] private string _key;
        [SerializeField] private bool _capitalize;

        private TextMeshProUGUI _textMeshProUGUI;
        private TextMeshPro _textMeshPro;
        private TextMesh _textMesh;
        private Text _text;
        private ToolTipSpawner _toolTipText;

        private void Awake()
        {
            switch (_textType)
            {
                case TextType.TextMeshProUGUI:
                    _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
                    break;
                case TextType.TextMeshPro:
                    _textMeshPro = GetComponent<TextMeshPro>();
                    break;
                case TextType.TextMesh:
                    _textMesh = GetComponent<TextMesh>();
                    break;
                case TextType.Text:
                    _text = GetComponent<Text>();
                    break;
                case TextType.ToolTipText:
                    _toolTipText = GetComponent<ToolTipSpawner>();
                    break;
                default:
                    break;
            }
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
            switch (_textType)
            {
                case TextType.TextMeshProUGUI:
                    _textMeshProUGUI.text = _capitalize ? localized.ToUpper() : localized;
                    break;
                case TextType.TextMeshPro:
                    _textMeshPro.text = _capitalize ? localized.ToUpper() : localized;
                    break;
                case TextType.TextMesh:
                    _textMesh.text = _capitalize ? localized.ToUpper() : localized;
                    break;
                case TextType.Text:
                    _text.text = _capitalize ? localized.ToUpper() : localized;
                    break;
                case TextType.ToolTipText:
                    _toolTipText.toolTipText = _capitalize ? localized.ToUpper() : localized;
                    break;
                default:
                    break;
            }
        }
    }

    public enum TextType
    {
        TextMeshProUGUI,
        TextMeshPro,
        TextMesh,
        Text,
        ToolTipText
    }
}
