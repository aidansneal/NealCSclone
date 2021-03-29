using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestinationLoad : MonoBehaviour
{
  
    //allows player to move between destinations on button click
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

}
