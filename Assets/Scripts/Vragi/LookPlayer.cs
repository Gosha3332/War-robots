using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookPlayer : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    void FixedUpdate()
    {
        transform.LookAt(Player.transform);
    }
}
