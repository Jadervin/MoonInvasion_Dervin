using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject turret;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newTurret = Instantiate(turret, transform.position, transform.rotation) as GameObject;
        newTurret.transform.SetParent(GameObject.FindGameObjectWithTag("Turret").transform, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
