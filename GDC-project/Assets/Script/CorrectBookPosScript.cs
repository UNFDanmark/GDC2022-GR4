using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectBookPosScript : MonoBehaviour
{
    public AudioClip bookCorrPos;
    public AudioClip PuzzleSolved;

    public bool[] bookPlacedCorrectly;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    int checkBook(Transform bookTransform)
    {
        bool isBook1 = bookTransform.gameObject.name == "Book1";
        bool isBook2 = bookTransform.gameObject.name == "Book2";
        bool isBook3 = bookTransform.gameObject.name == "Book3";
        bool isBook4 = bookTransform.gameObject.name == "Book4";
        bool isBook5 = bookTransform.gameObject.name == "Book5";
        bool isBook6 = bookTransform.gameObject.name == "Book6";
        bool isBook7 = bookTransform.gameObject.name == "Book7";
        bool isBook8 = bookTransform.gameObject.name == "Book8";
        bool isBook9 = bookTransform.gameObject.name == "Book9";
        bool isBook10 = bookTransform.gameObject.name == "Book10";

        float range = 0.001f;

        if (isBook1 && bookTransform.localPosition.x == 0)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 1;
        }
        else if(isBook1)
        {
            return -1;
        }
        if (isBook2 && Mathf.Abs(bookTransform.localPosition.x - -0.04249999f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 2;
        }
        else if (isBook2)
        {
            return -2;
        }

        if (isBook3 && Mathf.Abs(bookTransform.localPosition.x - 0.2178f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 3;
        }
        else if (isBook3)
        {
            return -3;
        }

        if (isBook4 && Mathf.Abs(bookTransform.localPosition.x - 0.1695f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 4;
        }
        else if (isBook4)
        {
            return -4;
        }

        if (isBook5 && Mathf.Abs(bookTransform.localPosition.x - 0.255f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 5;
        }
        else if (isBook5)
        {
            return -5;
        }

        if (isBook6 && Mathf.Abs(bookTransform.localPosition.x - 0.1307f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 6;
        }
        else if (isBook6)
        {
            return -6;
        }

        if (isBook7 && Mathf.Abs(bookTransform.localPosition.x - 0.298f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 7;
        }
        else if (isBook7)
        {
            return -7;
        }

        if (isBook8 && Mathf.Abs(bookTransform.localPosition.x - 0.0826f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 8;
        }
        else if (isBook8)
        {
            return -8;
        }

        if (isBook9 && Mathf.Abs(bookTransform.localPosition.x - 0.0371f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 9;
        }
        else if (isBook9)
        {
            return -9;
        }

        if (isBook10 && Mathf.Abs(bookTransform.localPosition.x - -0.0913f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 10;
        }
        else if (isBook10)
        {
            return -10;
        }

        return 0;

    }
    

    public void checkSwap(Transform bookTransform1, Transform bookTransform2)
    {

        int whichBook1 = checkBook(bookTransform1);
        int whichBook2 = checkBook(bookTransform2);

        if(whichBook1 != 0)
        {
            int index = Math.Abs(whichBook1) - 1;
            if(whichBook1 > 0)
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
