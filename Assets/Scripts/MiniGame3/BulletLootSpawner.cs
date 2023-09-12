using UnityEngine;

public class BulletLootSpawner : MonoBehaviour
{
    public GameObject bulletLoot;

    public float timeBetweenLootSpawns = 5f;

    float timer = 0f;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            float spawnY = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
            float spawnX = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);

            Vector2 spawnPosition = new(spawnX, spawnY);
            Instantiate(bulletLoot, spawnPosition, Quaternion.identity);

            timer = timeBetweenLootSpawns;
        }
    }
}
