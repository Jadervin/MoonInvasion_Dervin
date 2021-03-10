using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    private GameObject currentTurret;

    private Renderer rend;
    BuildManager buildManager;

    private Color startColor;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }
    private void OnMouseDown()
    {
        if(buildManager.GetTurretToBuild()==null)
        {
            return;
        }
        if(currentTurret!=null)
        {
            return;
        }
          //transform.rotation
        GameObject turretToBuild =buildManager.GetTurretToBuild();


        currentTurret = (GameObject)Instantiate(turretToBuild, transform.position, turretToBuild.transform.rotation);
    }

    private void OnMouseEnter()
    {
        if (buildManager.GetTurretToBuild() == null)
        {
            return;
        }
        rend.material.color = hoverColor;
    }


    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
