using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenChange : MonoBehaviour
{
    public void Playgame(string sceneName)
    {
    SceneManager.LoadScene(sceneName);
    }
}
    