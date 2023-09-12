using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class KillCountManager : MonoBehaviour
{
    public int killCount = 20;
    public static KillCountManager instance;

    public TextMeshProUGUI counterText;

    int counter;

    void Start()
    {
        instance = this;
        counter = killCount;
    }

    void Update()
    {
        counterText.text = counter.ToString();
        if (counter <= 0)
        {
            // Win Game
            GameData.aster = true;
            SceneManager.LoadScene(1);
            AudioManager.instance.Pause("theme");
        }
    }

    public void EnemyKilled()
    {
        counter--;
    }
}
