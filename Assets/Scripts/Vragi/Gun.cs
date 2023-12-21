using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Bullet;
    private float BulletVelosity = 25f;

    private void Start()
    {
        StartCoroutine(zadergka());
    }
    private IEnumerator zadergka()
    {
        while (true)
        {
            stralat();
            yield return new WaitForSeconds(3f);
        }

    }
    private void stralat()
    {
        GameObject newBullet = Instantiate(Bullet, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody>().velocity = transform.forward * BulletVelosity;
    }
}