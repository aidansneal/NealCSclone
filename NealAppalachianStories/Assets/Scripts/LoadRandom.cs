using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRandom : MonoBehaviour
{
    public void LoadRandomScene()
    {
        int index = Random.Range(1, 3);
        SceneManager.LoadScene(index);
        Debug.Log("Scene Loaded");
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
