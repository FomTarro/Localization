using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputField))]
public class PlayerNameInput : MonoBehaviour
{
    private InputField _input = null;

    // Start is called before the first frame update
    private void OnUpdate()
    {
        _input = GetComponent<InputField>();
        _input.onValueChanged.AddListener((string val) =>{
            // we can dynamically add new strings to our dictionary in a set of key/value pairs
            Dictionary<string, string> newStrings = new Dictionary<string, string>();
            // you probably want to do input santization here, up to you
            newStrings.Add("player_name", val);
            foreach(Localization.SupportedLanguage language in System.Enum.GetValues(typeof(Localization.SupportedLanguage)))
            {
                // add player name to every language dictionary
                Localization.LocalizationManager.Instance.AddStrings(newStrings, language);
            }
            Localization.LocalizationManager.Instance.RefreshAllLocalizedText();
        });
    }
}
