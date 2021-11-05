using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSway : MonoBehaviour
{

    private Quaternion startRotation;
    public float swayAmount = 8f;

    void Start()
    {
        startRotation = transform.localRotation; 
    }


    void Update()
    {
        Sway();
    }

    void Sway()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Quaternion xAngule = Quaternion.AngleAxis(mouseX * -1.25f, Vector3.up);
        Quaternion yAngule = Quaternion.AngleAxis(mouseY * -1.25f, Vector3.right);

        Quaternion targetRotation = startRotation * xAngule * yAngule;

        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, Time.deltaTime * swayAmount);



    }
}
