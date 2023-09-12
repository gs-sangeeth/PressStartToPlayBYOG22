using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public static HealthManager instance;
    public List<GameObject> hearts = new();

    private int health = 3;

    void Start()
    {
        instance = this;
        AudioManager.instance.Play("theme");
    }

    public void DecrementHealth()
    {
        health--;
        AudioManager.instance.Play("playerHit");
        CameraShake.instance.Shake();
        Destroy(hearts[hearts.Count-1]);
        hearts.RemoveAt(hearts.Count-1);
        if (health == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
