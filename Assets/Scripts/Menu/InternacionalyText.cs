using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InternacionalyText : MonoBehaviour
{
    [SerializeField] private string _en;
    [SerializeField] private string _ru;
    [SerializeField] private string _tr;

    private void Start()
    {
        if(Language.Instance.CurretLanguage == "en")
        {
            GetComponent<Text>().text = _en;
        }
        else if(Language.Instance.CurretLanguage == "ru")
        {
            GetComponent<Text>().text = _ru;
        }
        else if (Language.Instance.CurretLanguage == "tr")
        {
            GetComponent<Text>().text = _tr;
        }
        else
        {
            GetComponent<Text>().text = _en;
        }
    }


}
