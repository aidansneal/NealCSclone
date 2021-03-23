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
   





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
