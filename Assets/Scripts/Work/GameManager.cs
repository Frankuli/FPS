using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //patron singleton
    public static GameManager Instance { get; private set; }

    public int gunAmmon = 10;

    private void Awake()
    {
        Instance = this;
    }

}
