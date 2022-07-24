using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionScript : MonoBehaviour
{
    // Start is called before the first frame update

    Camera cam;
    
    
    void Start()
    {
        cam = GetComponent<Camera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Layer 3 is the book layer
            int layerMask = LayerMask.GetMask("Book");
            

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                Debug.Log("Did Hit");

                

                print("YAAAY!");
                // gør bogen lysere (sæt HUE på materialet)
            }
            else
            {
                Debug.Log("Did not Hit");
            }
        }
    }
}
