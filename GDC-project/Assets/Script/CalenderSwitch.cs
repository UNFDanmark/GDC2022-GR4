using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalenderSwitch : MonoBehaviour
{
    public GameObject other;
    public GameObject allNotes;
    Camera cam;
    Transform notePos1 = null, notePos2;

    void Swap()
    {
        Vector3 tempPosition = notePos1.transform.position;
        notePos1.transform.position = notePos2.transform.position;
        notePos2.transform.position = tempPosition;
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
            //Layer 7 is the notes layer
            int layerMask = LayerMask.GetMask("Notes");


            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {


                if (notePos1 == null)
                {
                    notePos1 = hit.collider.gameObject.transform;

                }
                else
                {
                    notePos2 = hit.collider.gameObject.transform;

                }
                if (notePos2 != null)
                {
                    Swap();

                    allNotes.GetComponent<NotesCorrectionScript>().checkNoteSwap(notePos1, notePos2);

                    notePos1 = null;
                    notePos2 = null;


                }

            }




        }
    }
}
