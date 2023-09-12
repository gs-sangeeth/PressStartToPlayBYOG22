using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{

    private void Start()
    {
        
    }

    public void loadscene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
