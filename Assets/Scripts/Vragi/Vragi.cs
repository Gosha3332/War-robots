using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vragi : MonoBehaviour
{
    public int health = 3;
    private void Update()
    {
        if (health <= 0){ Destroy(gameObject); }       
    }
    public void Damage()
    {
        health--;
    }
}
