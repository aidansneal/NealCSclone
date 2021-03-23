using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TriviaLoad : MonoBehaviour
{

    
    public GameObject correct;
    public GameObject incorrect;

    //
    public void HandleInputData(int val)
    {
        if(val == 2)
        {
            incorrect.SetActive(false);
            Debug.Log("Correct");
        } else
        {
   
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
