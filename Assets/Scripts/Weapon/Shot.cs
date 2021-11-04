using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public Transform spawnPonint;
    public GameObject bullet;
    public float shitForce = 1500f;
    public float shotRate = 0.5f;

    private float shotTime;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject newBullet;
            newBullet = Instantiate(bullet, spawnPonint.position, spawnPonint.rotation);
        }
        
    }
}
