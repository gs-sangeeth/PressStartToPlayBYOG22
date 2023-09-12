using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    public int bricksLeft;
    int health;
    public Transform[] hearts;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        hearts[0].gameObject.SetActive(true);
        hearts[1].gameObject.SetActive(true);
        bricksLeft = 56;
    }

    // Update is called once per frame
    public void Died()
    {
        health--;
        Debug.Log(health);

        switch (health)
        {
            case 2:
                hearts[0].gameObject.SetActive(false);
                break;
            case 1:
                hearts[1].gameObject.SetActive(false);
                break;
            case 0:
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                break;
        }
    }
    public void ReduceBrick()
    {
        bricksLeft--;

        if (bricksLeft <= 0)
        {
            GameData.ping = true;
            SceneManager.LoadScene(1);
        }
    }
}
