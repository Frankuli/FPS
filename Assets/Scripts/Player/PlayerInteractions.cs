using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GunAmmo"))
        {
            GameManager.Instance.gunAmmon += other.gameObject.GetComponent<AmmoBox>().ammo;//suma variable del ammo box


            Destroy(other.gameObject);
        }
    }
}
