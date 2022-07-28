using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZoomCalenderScript : MonoBehaviour
{
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
            //Layer 6 is the book layer
            int layerMask = LayerMask.GetMask("Clickable");



            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;



            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                Debug.Log("Did Hit");
                SceneManager.LoadScene("CalenderZoomScene");

            }
        }


    }
}