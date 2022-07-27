using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectBookPosScript : MonoBehaviour
{
    public GameObject[] allBooks;
    public AudioClip bookCorrPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void checkBook(Transform bookTransform)
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
        }

        if (isBook2 && Mathf.Abs(bookTransform.localPosition.x - -0.04249999f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
        }

        if (isBook3 && Mathf.Abs(bookTransform.localPosition.x - 0.2178f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
        }

        if (isBook4 && Mathf.Abs(bookTransform.localPosition.x - 0.1695f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
        }

        if (isBook5 && Mathf.Abs(bookTransform.localPosition.x - 0.255f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
        }

        if (isBook6 && Mathf.Abs(bookTransform.localPosition.x - 0.1307f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
        }

        if (isBook7 && Mathf.Abs(bookTransform.localPosition.x - 0.298f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
        }

        if (isBook8 && Mathf.Abs(bookTransform.localPosition.x - 0.0826f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
        }

        if (isBook9 && Mathf.Abs(bookTransform.localPosition.x - 0.0371f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
        }

        if (isBook10 && Mathf.Abs(bookTransform.localPosition.x - -0.0913f) < range)
        {
            AudioSource soundSource = gameObject.GetComponent<AudioSource>();
            soundSource.PlayOneShot(bookCorrPos);
        }
        


    }
    

    public void checkSwap(Transform bookTransform1, Transform bookTransform2)
    {
        checkBook(bookTransform1);
        checkBook(bookTransform2);

    }
}
