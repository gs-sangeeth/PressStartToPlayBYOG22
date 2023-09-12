using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    public static MouseCursor instance;

    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        Cursor.visible = false;
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
    }
}
