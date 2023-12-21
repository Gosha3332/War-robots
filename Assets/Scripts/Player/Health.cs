using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private int heals = 15;
    [SerializeField] private GameObject Panel;
    [SerializeField] private Text textHeals;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Vragi>()) { heals--; }
    }
    private void FixedUpdate()
    {
        if (heals<=0)
        { 
            Panel.SetActive(true);
            Time.timeScale = 0f;
            LoadScene.dead = true;
        }
        textHeals.text = heals.ToString() + "/15";	
    }

}
