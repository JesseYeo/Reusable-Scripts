using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SimpleLoader: MonoBehaviour
{
    public int targetScene;

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Next scene!");
    }

    public void BackScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("Going back to last scene!");
        Debug.Log(SceneManager.GetActiveScene().buildIndex - 1);

    }

    public void SimpleLoad()
    {
        SceneManager.LoadScene(targetScene);
        Debug.Log("Going to target scene!");
    }



}