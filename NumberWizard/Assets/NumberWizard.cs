using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int maxNumber = 1000;
        int minimumNumber = 1;
        int originalGuess = 500;

        // Debug.Log works the same as print, Debug gives a little more flexibility
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Please pick a number...");
        Debug.Log("The highest number that you can pick is: " + maxNumber);
        Debug.Log("The smallest number that you can pick is: " + minimumNumber);
        Debug.Log("Tell me if your guess is higher or lower than: " + originalGuess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        // Got information on how to do this on Unity's Docs
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow was pressed");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow was pressed");
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("We got the correct number!");
        }
    }
}
