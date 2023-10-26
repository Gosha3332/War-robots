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
    [SerializeField] private Transform _Camera;
    public float jumpForse;

    private void Start() { _ch = GetComponent<CharacterController>(); }
    private void FixedUpdate()
    {
        hodit();
        Forse = -10 * Time.deltaTime * 10f;
    }
    private void hodit()
    {
        Vector3 hodilka;
        hodilka.y = Forse;
        hodilka = _Camera.forward * _joystick.Vertical + _joystick.Horizontal * _Camera.right + transform.up * hodilka.y;
        _ch.Move(hodilka * _speed * Time.deltaTime);
    }
    public void Jump() { Forse = jumpForse; }



}
