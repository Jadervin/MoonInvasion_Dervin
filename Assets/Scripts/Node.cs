using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    private GameObject currentTurret;

    private Renderer rend;
    

    private Color startColor;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }
    private void OnMouseDown()
    {
        if(currentTurret!=null)
        {
            return;
        }
          //transform.rotation
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        currentTurret = (GameObject)Instantiate(turretToBuild, transform.position, turretToBuild.transform.rotation);
    }

    private void OnMouseEnter()
    {
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
