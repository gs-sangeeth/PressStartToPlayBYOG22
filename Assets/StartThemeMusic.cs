using UnityEngine;

public class StartThemeMusic : MonoBehaviour
{
    void Start()
    {
        AudioManager.instance.Play("menuTheme");
    }
}
