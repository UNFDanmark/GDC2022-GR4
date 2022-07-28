using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesScript : MonoBehaviour
{
    // Start is called before the first frame update
    Camera cam;

    
    Transform ShirtPos1 = null, ShirtPos2;
    public GameObject other;
    public GameObject allShirts;
    void Swap()
    {


        Vector3 tempPosition = ShirtPos1.transform.position;
        ShirtPos1.transform.position = ShirtPos2.transform.position;
        ShirtPos2.transform.position = tempPosition;
    }

    void Start()
    {
        cam = GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Layer 3 is the Shirt layer
            int layerMask = LayerMask.GetMask("Shirt");


            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {


                if (ShirtPos1 == null)
                {
                    ShirtPos1 = hit.collider.gameObject.transform;

                }
                else
                {
                    ShirtPos2 = hit.collider.gameObject.transform;

                }
                if (ShirtPos2 != null)
                {
                    Swap();

                    allShirts.GetComponent<CorrectShirtScript>().checkSwap(ShirtPos1, ShirtPos2);

                    ShirtPos1 = null;
                    ShirtPos2 = null;


                }
            }


        }
    }
}
