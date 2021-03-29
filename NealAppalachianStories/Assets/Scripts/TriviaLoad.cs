using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TriviaLoad : MonoBehaviour
{
// GameObjects for the "correct" and "incorrect" text that displays during trivia
    public GameObject correct;
    public GameObject incorrect;

    //input data for New River Gorge trivia -- the second value in the choices is the correct one
    public void HandleInputData1(int val)
    {
        if(val == 2)
        {
            correct.SetActive(true);
            incorrect.SetActive(false);
            Debug.Log("Correct");
        } else
        {
            incorrect.SetActive(true);
            correct.SetActive(false);
            Debug.Log("Incorrect");
        }
    }

    //input data for Natural Bridge trivia -- the second value in the choices is the correct one
    public void HandleInputData2(int val)
    {
        if (val == 3)
        {
            correct.SetActive(true);
            incorrect.SetActive(false);
            Debug.Log("Correct");
        }
        else
        {
            incorrect.SetActive(true);
            correct.SetActive(false);
            Debug.Log("Incorrect");
        }
    }

    //input data for Smoky Mountains trivia -- the first value in the choices is the correct one
    public void HandleInputData3(int val)
    {
        if (val == 1)
        {
            correct.SetActive(true);
            incorrect.SetActive(false);
            Debug.Log("Correct");
        }
        else
        {
            incorrect.SetActive(true);
            correct.SetActive(false);
            Debug.Log("Incorrect");
        }
    }

}
