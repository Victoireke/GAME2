using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startbutton : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("game");
    }
}
