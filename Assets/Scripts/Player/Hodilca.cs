using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Hodilca : MonoBehaviour
{
    [SerializeField] private FixedJoystick _joystick;
    private CharacterController _ch;
    private float Forse;
    [SerializeField] private float _speed;
    private float jumpForse = 10;
    private Vector3 hodilka;

    private void Start() { _ch = GetComponent<CharacterController>(); }
    private void FixedUpdate()
    {
        hodit();

    }
    private void hodit()
    {
        hodilka = Vector3.zero;
        hodilka.x = _joystick.Horizontal;
        hodilka.z = _joystick.Vertical;
        
        hodilka.y = Forse;
        hodilka = transform.right * hodilka.x + transform.forward * hodilka.z + transform.up * hodilka.y;
        _ch.Move(hodilka * _speed * Time.deltaTime);
        Forse = -14 * Time.deltaTime;
    }
    public void Jump()
    {
        if (_ch.isGrounded)
        {
            Forse = jumpForse;
        }

    }

}
