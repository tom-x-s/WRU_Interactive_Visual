using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void NextScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void Home()
    {
        SceneManager.LoadScene("Menu");
    }
}
