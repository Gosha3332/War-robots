using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Dvigenie : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] Transform Player;
    private void Start(){ _rb = GetComponent<Rigidbody>(); }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector3(Player.position.x-transform.position.x  ,_rb.velocity.y, Player.position.z - transform.position.z);
    }
}
