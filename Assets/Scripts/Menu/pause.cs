using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    [SerializeField] private GameObject Panel;

    public void StopVreva()
    {  
        Time.timeScale = 0f; 
        Panel.SetActive(true);
    }
    public void GameRun()
    {        
        Time.timeScale = 1f;
        Panel.SetActive(false);
    } 
}
