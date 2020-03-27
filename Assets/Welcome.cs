using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Welcome : MonoBehaviour
{
    public int max;
    public int min;
    public int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;


        Debug.Log("Hello there,welcome to the number wizard, YO");
        Debug.Log("Pick a number from " + min + "-" + max);
        Debug.Log("Is it higher or lower than " + "\"" + guess + "\"");
        Debug.Log("If it's higher, press up.");
        Debug.Log("If it's lower, press down");
        Debug.Log("Press Enter to if it's correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {

            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I got it");
            Debug.Log("Press Enter to play again");
            StartGame();
        }

    void NextGuess()
        {
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than " + "\"" + guess + "\"");
        }
    }
}
