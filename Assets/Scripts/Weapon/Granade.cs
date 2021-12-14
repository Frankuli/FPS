using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granade : MonoBehaviour
{
    [SerializeField] private bool exploted = false;
    [SerializeField] private float countdown;

    public float delay = 3;
    public float radius = 5;
    public float explosionForce = 70;
    
    void Start()
    {
        countdown = delay;
    }


    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0 && exploted == false)
        {
            Explode();
            exploted = true;
        }
        
    }

    void Explode()
    {
        Collider[] collider = Physics.OverlapSphere(transform.position, radius);

        foreach (var rangeObject in collider)
        {
            Rigidbody rb = rangeObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce * 10, transform.position, radius);
            }
        }

        Destroy(gameObject);
    }
}
