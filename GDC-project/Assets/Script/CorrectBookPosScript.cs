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
    
    public void checkSwap(Transform bookTransform1, Transform bookTransform2)
    {
        bool isBook1 = bookTransform1.gameObject.name == "Book1";
        bool isBook2 = bookTransform1.gameObject.name == "Book2";
        bool isBook3 = bookTransform1.gameObject.name == "Book3";
        bool isBook4 = bookTransform1.gameObject.name == "Book4";
        bool isBook5 = bookTransform1.gameObject.name == "Book5";
        bool isBook6 = bookTransform1.gameObject.name == "Book6";
        bool isBook7 = bookTransform1.gameObject.name == "Book7";
        bool isBook8 = bookTransform1.gameObject.name == "Book8";
        bool isBook9 = bookTransform1.gameObject.name == "Book9";
        bool isBook10 = bookTransform1.gameObject.name == "Book10";
        


        if (isBook1 && bookTransform1.localPosition.x == 0)
        {
            print("Correct position!1");
        }

        if (isBook2 && bookTransform1.localPosition.x < -0.05249999 && bookTransform1.localPosition.x < -0)
        {
            print("Correct position!2");
        }

        if (isBook3 && bookTransform1.localPosition.x == 0.2178)
        {
            print("Correct position!3");
        }

        if (isBook4 && bookTransform1.localPosition.x == 0.1695)
        {
            print("Correct position!4");
        }

        if (isBook5 && bookTransform1.localPosition.x == 0.255)
        {
            print("Correct position5!");
        }

        if (isBook6 && bookTransform1.localPosition.x == 0.1307)
        {
            print("Correct position6!");
        }

        if (isBook7 && bookTransform1.localPosition.x == 0.298)
        {
            print("Correct position7!");
        }

        if (isBook8 && bookTransform1.localPosition.x == 0.0826)
        {
            print("Correct position!8");
        }

        if (isBook9 && bookTransform1.localPosition.x == 0.0371)
        {
            print("Correct position!9");
        }

        if (isBook10 && bookTransform1.localPosition.x == -0.0913)
        {
            print("Correct position!10");
        }


    }
}
