using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBol : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(ydolat());
    }
    private IEnumerator ydolat()
    {
        yield return new WaitForSeconds(0.9f);
        Destroy(gameObject);
    }
}
