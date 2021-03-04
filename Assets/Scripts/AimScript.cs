using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimScript : MonoBehaviour
{
    public GameObject body;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Aim();
    }

    void Aim()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            //Instantiate(PrimitiveType.Sphere, hit.point, Quaternion.identity);
            Vector3 hoverPosition = hit.point;
            hoverPosition.y = body.transform.position.y;

            body.transform.LookAt(hoverPosition, Vector3.up);
            //player.destination = hit.point;
        }

        




    }
}
