using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Main scriptable object used for localization purposes
/// </summary>
[CreateAssetMenu(fileName = "New string",menuName = "Loc. String")]
public class LocalizableString : ScriptableObject
{

    public string english;
    public string ukraine;

    public string GetString(Language language)
    {
        switch (language)
        {
            case Language.Ukraine:
                return ukraine;
            case Language.English:
                return english;
        }
        return null;
    }

    [System.Serializable]

    public enum Language { English, Ukraine};
}
