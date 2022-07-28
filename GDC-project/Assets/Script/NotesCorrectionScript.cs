
using UnityEngine;
using System;



public class NotesCorrectionScript : MonoBehaviour
{

    public AudioClip bookCorrPos;
    public AudioClip PuzzleSolved;

    public bool[] notePlacedCorrectly;

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

        if (isNote1 && Mathf.Abs(noteTransform.localPosition.y - 0.003f) < noteRange)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 1;
        }
        else if (isNote1)
        {
            return -1;
        }
        if (isNote2 && Mathf.Abs(noteTransform.localPosition.y - 0.129f) < noteRange)
        {
            
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 2;
        }
        else if (isNote2)
        {
            return -2;
        }

        if (isNote3 && Mathf.Abs(noteTransform.localPosition.y - 0.083f) < noteRange)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 3;
        }
        else if (isNote3)
        {
            return -3;
        }

        if (isNote4 && Mathf.Abs(noteTransform.localPosition.y - -0.045f) < noteRange)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 4;
        }
        else if (isNote4)
        {
            return -4;
        }

        if (isNote5 && Mathf.Abs(noteTransform.localPosition.y - -0.091f) < noteRange)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 5;
        }
        else if (isNote5)
        {
            return -5;
        }

        if (isNote6 && Mathf.Abs(noteTransform.localPosition.y - 0.04f) < noteRange)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 6;
        }
        else if (isNote6)
        {
            return -6;
        }

        if (isNote7 && Mathf.Abs(noteTransform.localPosition.y - -0.135f) < noteRange)
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

        int whichNote1 = checkNote(noteTransform1);
        int whichNote2 = checkNote(noteTransform2);

        if (whichNote1 != 0)
        {
            int index = Math.Abs(whichNote1) - 1;
            if (whichNote1 > 0)
            {
                notePlacedCorrectly[index] = true;
            }
            else
            {
                notePlacedCorrectly[index] = false;
            }

        }
        if (whichNote2 != 0)
        {
            int index = Math.Abs(whichNote2) - 1;
            if (whichNote2 > 0)
            {
                notePlacedCorrectly[index] = true;
            }
            else
            {
                notePlacedCorrectly[index] = false;
            }
        }
        if (notePlacedCorrectly[0] && notePlacedCorrectly[1] && notePlacedCorrectly[2] && notePlacedCorrectly[3] && notePlacedCorrectly[4] && notePlacedCorrectly[5] && notePlacedCorrectly[6])
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(PuzzleSolved);

            GameObject scoreS = GameObject.FindGameObjectWithTag("Score2");
            scoreS.GetComponent<TMPro.TextMeshProUGUI>().text = "A";
        }

    
}
    
        
}

