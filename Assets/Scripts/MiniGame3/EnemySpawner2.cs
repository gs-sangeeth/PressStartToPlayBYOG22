using UnityEngine;

public class EnemySpawner2 : MonoBehaviour
{
    public float timeBetweenEnemySpawns = 0.5f;

    public GameObject[] enemies;

    float timer = 0f;

    public int totalNoOfEnemiesInScreen = 6;

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f && GameObject.FindGameObjectsWithTag("Enemy").Length < totalNoOfEnemiesInScreen)
        {
            var obj = Instantiate(enemies[Random.Range(0,enemies.Length)], RandomCircle(new Vector2(0, 0), 9), Quaternion.identity);
            timer = timeBetweenEnemySpawns;
        }
    }

    Vector2 RandomCircle(Vector2 center, float radius)
    {
        float ang = Random.value * 360;
        Vector2 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        return pos;
    }
}
