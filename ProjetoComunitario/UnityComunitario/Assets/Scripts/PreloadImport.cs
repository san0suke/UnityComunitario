using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreloadImport : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("_preload", LoadSceneMode.Additive);
    }
}
