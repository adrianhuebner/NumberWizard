using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    
    int maxNumber = 1000;
    int minimumNumber = 1;
    int currentGuess = 500;

    void Start()
    {
        // Debug.Log works the same as print, Debug gives a little more flexibility
        Debug.Log("Hello and welcome to Number Wizard!");
        Debug.Log("Please pick any number between " + maxNumber + " and " + minimumNumber);
        Debug.Log("Tell me if your guess is higher or lower than: " + currentGuess);
        Debug.Log("Press the Up Arrow on your Keyboard if the number you are thinking of is higher \n Press the Down Arrow on your Keyboard if the number you are thinking of is lower \n Press the Enter/Return Key on your Keyboard if it is the number you are thinking of");

        maxNumber = maxNumber + 1;
    }

   
    void Update()
    {
        // Got information on how to do this on Unity's Docs
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minimumNumber = currentGuess;
            currentGuess = ((maxNumber + minimumNumber) / 2);
            Debug.Log("You need a higher number, here is our next guess: " + currentGuess);
                
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxNumber = currentGuess;
            currentGuess = ((maxNumber + minimumNumber) / 2);
            Debug.Log("You need a lower number, here is our next guess: " + currentGuess);
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("We guessed the correct number!");
        }
    }
}
