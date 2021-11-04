using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float moveSensivity = 80f;
    public Transform playerBody;

    private float xRotation = 0f;
    private float maxRotation = 90f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;//hace queel mouse siempre este en la pantalla del juego
    }

    void Update()
    {

        Camera();

    }

    void Camera()
    {
        float mouseX = Input.GetAxis("Mouse X") * moveSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * moveSensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -maxRotation, maxRotation);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
