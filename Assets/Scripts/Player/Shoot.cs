using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    private Vragi vrag;
    [SerializeField] private AudioSource shootMp3;
    [SerializeField] private ParticleSystem Effekt;
    private int patrons = 30;
    [SerializeField] Text patronText;
    private void FixedUpdate()
    {
        patronText.text = patrons.ToString() + "/30";
        if (patrons < 0) { patrons = 30; }
    }
    public void shoot()
    {
        Ray luch = new Ray(transform.position, transform.forward);

        if (patrons > 0) { shootMp3.Play(); }
        patrons--;
        if (patrons > 0) { Effekt.Play(); }

        if (Physics.Raycast(luch, out RaycastHit hit))
        {
            //Debug.Log(hit.collider);
            if (hit.rigidbody != null) { hit.rigidbody.AddForce(-hit.normal * 150f); }
            if (hit.collider.GetComponent<Vragi>() && patrons > 0) { hit.collider.GetComponent<Vragi>().Damage(); }
        }
    }
}