using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Transform Camera;

    [SerializeField] private float sensivity;
    private int FingerId;

    private float WichScreenSize;

    private Vector2 LookInput;
    private float CameraPitch;



    void Start()
    {
        Time.timeScale = 1.0f;
        FingerId = -1;
        WichScreenSize = Screen.width / 2;
    }

    private void FixedUpdate()
    {
        FingerTouch();
        if (FingerId != -1)
        {
            CameraRot();
        }

    }

    private void FingerTouch()
    {

        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x > WichScreenSize && FingerId == -1)
                    {
                        FingerId = touch.fingerId;
                    }
                    break;
                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    if (touch.fingerId == FingerId)
                    {
                        FingerId = -1;
                    }
                    break;
                case TouchPhase.Moved:
                    if (touch.fingerId == FingerId)
                    {
                        LookInput = touch.deltaPosition * sensivity * Time.deltaTime;
                    }
                    break;
                case TouchPhase.Stationary:
                    if (touch.fingerId == FingerId)
                    {
                        LookInput = Vector2.zero;
                    }
                    break;
            }
        }
    }
    private void CameraRot()
    {
        CameraPitch = Mathf.Clamp(CameraPitch - LookInput.y, -90, 90);
        Camera.localRotation = Quaternion.Euler(CameraPitch, 0, 0);

        transform.Rotate(transform.up, LookInput.x);
    }
}
