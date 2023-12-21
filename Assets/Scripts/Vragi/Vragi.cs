using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vragi : MonoBehaviour
{
    public int health;
    [SerializeField] private Win Metod;

    private void FixedUpdate()
    {
        if (health <= 0){ Destroy(gameObject); }       
    }
    public void Damage()
    {
        health--;
        if (health <= 0) { Metod.killed();}
    }
}