using UnityEngine;
using TMPro;

public class BulletLoot : MonoBehaviour
{
    public float lifeTime = 4f;
    public int bulletCount = 10;

    public TextMeshProUGUI countText;

    private void Start()
    {
        countText.text = bulletCount.ToString();
    }

    void Update()
    {
        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
