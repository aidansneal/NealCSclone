using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestinationLoad : MonoBehaviour
{
  
    //allows player to go back to destination 1 by OnClick
    public void Destination1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    public void Destination2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Destination3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
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
