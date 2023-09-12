using UnityEngine;

public class creditmanager : MonoBehaviour
{
    public GameObject platformer;
    public GameObject pingpong;
    public GameObject asteroid;
    public GameObject win;
    public GameObject credits;

    public static creditmanager instance;

    void Start()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
        //win asteroids unlock 2nd game
        if (GameData.aster == true)
            platformer.SetActive(true);
        


        //win 2nd game to unlock 3rd game
        if (GameData.plat == true)
            pingpong.SetActive(true);

        //win all game
        if (GameData.ping ==  true)
        {
            win.SetActive(true);
            credits.SetActive(false);
        }

    }
}
