using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject vrag;
    void FixedUpdate()
    {
        StartCoroutine(sp());
    }

    private IEnumerator sp()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);
            spawn();
        }
    }
    private void spawn()
    {
        Instantiate(vrag);
    }
}
