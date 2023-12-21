using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject vrag;
    private void Start()
    {
        StartCoroutine(spawn());
    }
    private void sp()
    {
        Instantiate(vrag, transform.position, transform.rotation);
    }
    private IEnumerator spawn()
    {
        while (true)
        {
            sp();
            yield return new WaitForSeconds(12);
        }

    }
}
