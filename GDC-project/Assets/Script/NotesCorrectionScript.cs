using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesCorrectionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
        void checkNotes(Transform noteTransform)
        {
            bool isNote1 = noteTransform.gameObject.name == "PostItNote1";
            bool isNote2 = noteTransform.gameObject.name == "PostItNote2";
            bool isNote3 = noteTransform.gameObject.name == "PostItNote3";
            bool isNote4 = noteTransform.gameObject.name == "PostItNote4";
            bool isNote5 = noteTransform.gameObject.name == "PostItNote5";
            bool isNote6 = noteTransform.gameObject.name == "PostItNote6";
            bool isNote7 = noteTransform.gameObject.name == "PostItNote7";

            float noteRange = 0.001f;

            if (isNote1 && noteTransform.localPosition.x == 0)
            {
                print("Correct position!1");
            }

            if (isNote2 && Mathf.Abs(noteTransform.localPosition.y - -0.04249999f) < noteRange)
            {
                print("Correct position!2");
            }

            if (isNote3 && Mathf.Abs(noteTransform.localPosition.y - 0.2178f) < noteRange)
            {
                print("Correct position!3");
            }

            if (isNote4 && Mathf.Abs(noteTransform.localPosition.y - 0.1695f) < noteRange)
            {
                print("Correct position!4");
            }

            if (isNote5 && Mathf.Abs(noteTransform.localPosition.y - 0.255f) < noteRange)
            {
                print("Correct position5!");
            }

            if (isNote6 && Mathf.Abs(noteTransform.localPosition.y - 0.1307f) < noteRange)
            {
                print("Correct position6!");
            }

            if (isNote7 && Mathf.Abs(noteTransform.localPosition.y - 0.298f) < noteRange)
            {
                print("Correct position7!");
            }
        }
        public void checkNoteSwap(Transform noteTransform1, Transform noteTransform2)
        {
            checkNotes(noteTransform1);
            checkNotes(noteTransform2);
        }


    }

