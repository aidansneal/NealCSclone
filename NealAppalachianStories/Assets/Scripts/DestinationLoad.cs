using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestinationLoad : MonoBehaviour
{
  
    //allows player to go back to destination 1 by OnClick
    public void Destination1()
    {
        SceneManager.LoadScene("Destination1", LoadSceneMode.Single);
    }

    public void Destination2()
    {
        SceneManager.LoadScene("Destination2", LoadSceneMode.Single);
    }
    public void Destination3()
    {
        SceneManager.LoadScene("Destination3", LoadSceneMode.Single);
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
