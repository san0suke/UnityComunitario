using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreloadImport : MonoBehaviour
{
    void Start()
    {
        var __app = GameObject.Find("__app");
        if(__app == null)
        {
            SceneManager.LoadScene("_preload", LoadSceneMode.Additive);
        }
    }
}
