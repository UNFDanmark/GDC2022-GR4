
using UnityEngine;
using System;



public class NotesCorrectionScript : MonoBehaviour
{

    public AudioClip bookCorrPos;
    public AudioClip PuzzleSolved;

    public bool[] bookPlacedCorrectly;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    int checkNote(Transform noteTransform)
    {
        bool isNote1 = noteTransform.gameObject.name == "PostItNote1";
        bool isNote2 = noteTransform.gameObject.name == "PostItNote2";
        bool isNote3 = noteTransform.gameObject.name == "PostItNote3";
        bool isNote4 = noteTransform.gameObject.name == "PostItNote4";
        bool isNote5 = noteTransform.gameObject.name == "PostItNote5";
        bool isNote6 = noteTransform.gameObject.name == "PostItNote6";
        bool isNote7 = noteTransform.gameObject.name == "PostItNote7";

        float noteRange = 0.001f;

        if (isNote1 && Mathf.Abs(noteTransform.localPosition.y - -0.001679339f) < noteRange)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 1;
        }
        else if (isNote1)
        {
            return -1;
        }
        if (isNote2 && Mathf.Abs(noteTransform.localPosition.y - 0.1285207f) < noteRange)
        {
            
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 2;
        }
        else if (isNote2)
        {
            return -2;
        }

        if (isNote3 && Mathf.Abs(noteTransform.localPosition.y - 0.08412066f) < noteRange)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 3;
        }
        else if (isNote3)
        {
            return -3;
        }

        if (isNote4 && Mathf.Abs(noteTransform.localPosition.y - -0.04857934f) < noteRange)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 4;
        }
        else if (isNote4)
        {
            return -4;
        }

        if (isNote5 && Mathf.Abs(noteTransform.localPosition.y - -0.09187934f) < noteRange)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 5;
        }
        else if (isNote5)
        {
            return -5;
        }

        if (isNote6 && Mathf.Abs(noteTransform.localPosition.y - 0.04162067f) < noteRange)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 6;
        }
        else if (isNote6)
        {
            return -6;
        }

        if (isNote7 && Mathf.Abs(noteTransform.localPosition.y - -0.1375793f) < noteRange)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 7;
        }
        else if (isNote7)
        {
            return -7;
        }

        

        return 0;

    }


    public void checkSwap(Transform noteTransform1, Transform noteTransform2)
    {

        int whichBook1 = checkNote(noteTransform1);
        int whichBook2 = checkNote(noteTransform2);

        if (whichBook1 != 0)
        {
            int index = Math.Abs(whichBook1) - 1;
            if (whichBook1 > 0)
            {
                bookPlacedCorrectly[index] = true;
            }
            else
            {
                bookPlacedCorrectly[index] = false;
            }

        }
        if (whichBook2 != 0)
        {
            int index = Math.Abs(whichBook2) - 1;
            if (whichBook2 > 0)
            {
                bookPlacedCorrectly[index] = true;
            }
            else
            {
                bookPlacedCorrectly[index] = false;
            }
        }
        if (bookPlacedCorrectly[0] && bookPlacedCorrectly[1] && bookPlacedCorrectly[2] && bookPlacedCorrectly[3] && bookPlacedCorrectly[4] && bookPlacedCorrectly[5] && bookPlacedCorrectly[6] && bookPlacedCorrectly[7] && bookPlacedCorrectly[8] && bookPlacedCorrectly[9])
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(PuzzleSolved);
        }

    
}
    
        
}

