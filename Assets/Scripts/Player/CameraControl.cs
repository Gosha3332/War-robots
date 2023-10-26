using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Transform Camera;

    [SerializeField] private float sensivity;
    private int FingerId;

    private Vector2 AnglRotate;
    private float AnglX;
    private float AnglY;

    private float WichScreenSize;

    void Start()
    {
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
                        AnglRotate = touch.deltaPosition * sensivity * Time.deltaTime;
                    }
                    break;
                case TouchPhase.Stationary:
                    if (touch.fingerId == FingerId)
                    {
                        AnglRotate = Vector2.zero;
                    }
                    break;
            }
        }
    }
    private void CameraRot()
    {
        AnglX = Mathf.Clamp(AnglX - AnglRotate.y, -69, 69);
        //AnglY = Mathf.Clamp(AnglY - AnglRotate.x, -360, 360);
        Camera.localRotation = Quaternion.Euler(AnglX,0, 0);
        transform.localRotation = Quaternion.Euler(AnglX, 0, 0);

        transform.Rotate(transform.up, AnglRotate.x);
    }
}
