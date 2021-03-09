using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHealth : MonoBehaviour
{

    public int tankMaxHP;
    //[HideInInspector]
    public int tankcurrentHP=0;

    public int tankNoHP;

    // Start is called before the first frame update
    void Start()
    {
        tankcurrentHP = tankMaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
