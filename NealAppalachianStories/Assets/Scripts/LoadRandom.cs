using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRandom : MonoBehaviour
{
    //Loads random scene when START is clicked
    public void LoadRandomScene()
    {
        //random range for scenes
        int index = Random.Range(1, 3);
        SceneManager.LoadScene(index);
        Debug.Log("Scene Loaded");
    }

}
