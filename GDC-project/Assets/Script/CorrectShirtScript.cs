using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectShirtScript : MonoBehaviour
{

    public bool[] twoShirts;
    public AudioClip bookCorrPos;
    public AudioClip PuzzleSolved;


    public bool[] ShirtPlacedCorrectly;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    int checkShirt(Transform ShirtTransform)
    {
        bool isShirt1 = ShirtTransform.gameObject.name == "Shirt1";
        bool isShirt2 = ShirtTransform.gameObject.name == "Shirt2";

        float range = 0.001f;

        if (isShirt1 && Mathf.Abs(ShirtTransform.localPosition.x - -0.149f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 1;
        }
        else if (isShirt1)
        {
            return -1;
        }
        if (isShirt2 && Mathf.Abs(ShirtTransform.localPosition.x - 0.15f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
            return 2;
        }
        else if (isShirt2)
        {
            return -2;
        }


        return 0;
    }


    public void checkSwap(Transform ShirtTransform1, Transform ShirtTransform2)
    {

        int whichShirt1 = checkShirt(ShirtTransform1);
        int whichShirt2 = checkShirt(ShirtTransform2);

        if (whichShirt1 != 0)
        {
            int index = Math.Abs(whichShirt1) - 1;
            if (whichShirt1 > 0)
            {
                ShirtPlacedCorrectly[index] = true;
            }
            else
            {
                ShirtPlacedCorrectly[index] = false;
            }

        }
        if (whichShirt2 != 0)
        {
            int index = Math.Abs(whichShirt2) - 1;
            if (whichShirt2 > 0)
            {
                ShirtPlacedCorrectly[index] = true;
            }
            else
            {
                ShirtPlacedCorrectly[index] = false;
            }
        }
        if (ShirtPlacedCorrectly[0] && ShirtPlacedCorrectly[1])
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(PuzzleSolved);

            GameObject scoreS = GameObject.FindGameObjectWithTag("Score3");
            scoreS.GetComponent<TMPro.TextMeshProUGUI>().text = "M";
        }

    }
    
}
