using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG1Manager : MonoBehaviour
{
    int health = 3;

    public static MG1Manager instance;

    public List<GameObject> hearts = new();

    void Start()
    {
        instance = this;
    }

    void Update()
    {
        if (health < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        switch (health)
        {
            case 0:
                hearts[0].SetActive(false);
                hearts[1].SetActive(false);
                hearts[2].SetActive(false);
                break;

            case 1:
                hearts[0].SetActive(true);
                hearts[1].SetActive(false);
                hearts[2].SetActive(false);
                break;

            case 2:
                hearts[0].SetActive(true);
                hearts[1].SetActive(true);
                hearts[2].SetActive(false);
                break;

            case 3:
                hearts[0].SetActive(true);
                hearts[1].SetActive(true);
                hearts[2].SetActive(true);
                break;
        }
    }

    public void Hit()
    {
        health--;
    }

    public void CollectPowerUp()
    {
        if (health < 3)
        {
            health++;
        }
    }
}
