using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text ammoText;
    public Text healthText;

    //patron singleton
    public static GameManager Instance { get; private set; }

    public int gunAmmon = 10;
    public int health = 100;



    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        ammoText.text = gunAmmon.ToString();
        healthText.text = health.ToString();
    }

}
