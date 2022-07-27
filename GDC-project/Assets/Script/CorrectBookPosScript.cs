using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectBookPosScript : MonoBehaviour
{
    public GameObject[] allBooks; 
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
            print("Correct position!1");
        }

        if (isBook2 && Mathf.Abs(bookTransform.localPosition.x - -0.04249999f) < range)
        {
            print("Correct position!2");
        }

        if (isBook3 && Mathf.Abs(bookTransform.localPosition.x - 0.2178f) < range)
        {
            print("Correct position!3");
        }

        if (isBook4 && Mathf.Abs(bookTransform.localPosition.x - 0.1695f) < range)
        {
            print("Correct position!4");
        }

        if (isBook5 && Mathf.Abs(bookTransform.localPosition.x - 0.255f) < range)
        {
            print("Correct position5!");
        }

        if (isBook6 && Mathf.Abs(bookTransform.localPosition.x - 0.1307f) < range)
        {
            print("Correct position6!");
        }

        if (isBook7 && Mathf.Abs(bookTransform.localPosition.x - 0.298f) < range)
        {
            print("Correct position7!");
        }

        if (isBook8 && Mathf.Abs(bookTransform.localPosition.x - 0.0826f) < range)
        {
            print("Correct position!8");
        }

        if (isBook9 && Mathf.Abs(bookTransform.localPosition.x - 0.0371f) < range)
        {
            print("Correct position!9");
        }

        if (isBook10 && Mathf.Abs(bookTransform.localPosition.x - -0.0913f) < range)
        {
            print("Correct position!10");
        }
        
    }
    

    public void checkSwap(Transform bookTransform1, Transform bookTransform2)
    {
        checkBook(bookTransform1);
        checkBook(bookTransform2);

    }
}
