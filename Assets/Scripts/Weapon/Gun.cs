using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform spawnPonint;
    public GameObject bullet;
    public float shotForce = 1500f;
    public float shotRate = 0.5f;
    public float destroyTime = 5f;

    private float shotRateTime;



    void Update()
    {
        Shoot();
        
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time > shotRateTime && GameManager.Instance.gunAmmon > 0 )
        {
            GameManager.Instance.gunAmmon--;
            GameObject newBullet;
            newBullet = Instantiate(bullet, spawnPonint.position, spawnPonint.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(spawnPonint.forward * shotForce);

            shotRateTime = Time.time + shotRate;

            Destroy(newBullet, destroyTime);

        }
    }
}
