using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinConditionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if collider hits win tile you win
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // new scene

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            GameData.plat = true;
            AudioManager.instance.Pause("platformerTheme");

            SceneManager.LoadScene("Creditscene");

        }
    }
}
