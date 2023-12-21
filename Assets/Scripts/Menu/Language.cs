using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using TMPro;

public class Language : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern string GetLang();

    public string CurretLanguage;
    public static Language Instance;

    [SerializeField] private TextMeshProUGUI _languageText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            CurretLanguage = GetLang();
            _languageText.text = GetLang();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
