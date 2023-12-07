using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class simple : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickQuit()
    {
        Application.Quit();
    }

    public void OnClickPlay()
    {
        SceneManager.LoadScene("Hospital_Level");
    }
}
