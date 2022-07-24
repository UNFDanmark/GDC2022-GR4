using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionScript : MonoBehaviour
{
    // Start is called before the first frame update

    Camera cam;

    Transform bookPos1 = null, bookPos2;
    public GameObject other;

    void Swap()
    {
        Vector3 tempPosition = bookPos1.transform.position;
        bookPos1.transform.position = bookPos2.transform.position;
        bookPos2.transform.position = tempPosition;
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
            //Layer 3 is the book layer
            int layerMask = LayerMask.GetMask("Book");


            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;



            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                Debug.Log("Did Hit");
                /*
                bookPos1 = hit.collider.gameObject.transform;
                Debug.Log(bookPos1.localPosition.x);
                Debug.Log(bookPos1.localPosition.y);
                Debug.Log(bookPos1.localPosition.z);

                bookPos2 = hit.collider.gameObject.transform;
                Debug.Log(bookPos2.localPosition.x);
                Debug.Log(bookPos2.localPosition.y);
                Debug.Log(bookPos2.localPosition.z);
                */

                if (bookPos1 == null)
                {
                    bookPos1 = hit.collider.gameObject.transform;
                    Debug.Log("BookPos1");
                }
                else
                {
                    bookPos2 = hit.collider.gameObject.transform;
                    Debug.Log("BookPos2");
                }
                if (bookPos2 != null)
                {
                    Swap();

                    bookPos1 = null;
                    bookPos2 = null;
                }
                
                

            }

            // gør bogen lysere (sæt HUE på materialet)
        }
    }
}

