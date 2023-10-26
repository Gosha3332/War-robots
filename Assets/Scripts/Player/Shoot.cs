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
    private bool perezarad;
    //private bool strelba = false;
    //public void OnPointerDown() { Touch = true; }
    //public void OnPointerUp() { Touch = false; }
    private void FixedUpdate()
    {
        //if(patrons >= 0) { StartCoroutine("perezaradka"); }
        patronText.text = patrons.ToString();
        if (patrons < 0) { patrons = 30; }
    }
    public void shoot()
    {
        Ray luch = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (patrons > 0) { shootMp3.Play(); }
        patrons--;
        if (patrons > 0) { Effekt.Play(); }

        if (Physics.Raycast(luch, out hit))
        {
            //Debug.Log(hit.collider);
            if (hit.rigidbody != null) { hit.rigidbody.AddForce(-hit.normal * 150f); }
            if (hit.collider.GetComponent<Vragi>() && patrons > 0) { hit.collider.GetComponent<Vragi>().Damage(); }
        }
    }
    private IEnumerator perezaradka()
    {
        patrons = 30;
        yield return new WaitForSeconds(2f);
    }

}
