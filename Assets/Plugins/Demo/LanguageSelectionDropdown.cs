
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Dropdown))]
public class LanguageSelectionDropdown : MonoBehaviour
{

    private Dropdown _dropdown = null;
    // Start is called before the first frame update
    private Dictionary<int, Localization.SupportedLanguage> map = new Dictionary<int, Localization.SupportedLanguage>();
    void Start()
    {
        int i = 0;
        _dropdown = GetComponent<Dropdown>();
        List<Dropdown.OptionData> options = new List<Dropdown.OptionData>();
        foreach(Localization.SupportedLanguage language in System.Enum.GetValues(typeof(Localization.SupportedLanguage))){
            Dropdown.OptionData data = new Dropdown.OptionData();
            // get each language's name in itself
            data.text = Localization.LocalizationManager.Instance.GetString("language", language);
            options.Add(data);
            map.Add(i, language);
            i++;
        }

        _dropdown.options = options;
        _dropdown.onValueChanged.AddListener((int index) => {
            Localization.LocalizationManager.Instance.SwitchLanguage(map[index]);
        });
    }

}
