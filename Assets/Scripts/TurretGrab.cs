using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretGrab : MonoBehaviour
{
    BuildManager buildMan;

    // Start is called before the first frame update
    void Start()
    {
        buildMan = BuildManager.instance;
    }

    public void GetTurret1()
    {
        buildMan.SetTurretToBuild(buildMan.standardTurretPrefab);
    }

    public void GetTurret2()
    {
        buildMan.SetTurretToBuild(buildMan.anotherTurretPrefab);
    }
    public void Shield()
    {
        buildMan.SetTurretToBuild(buildMan.shieldPrefab);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
