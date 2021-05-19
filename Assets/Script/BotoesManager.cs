using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotoesManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnSair()
    {
        Application.Quit();
    }

    public void OnJogo()
    {
        SceneManager.LoadScene(1);
    }
}
