using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float timeBetweenEnemySpawns = 0.5f;
    public float enemySpeed;

    public GameObject enemy;

    float timer = 0f;

    void Update()
    {
        float spawnX = Random.Range
            (-Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);

        //Debug.DrawLine(
        //    new Vector2(Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y),
        //    new Vector2(-Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y),
        //    Color.red
        //);

        Vector2 enemySpawnPos = new(spawnX, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);

        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            var obj = Instantiate(enemy, enemySpawnPos, Quaternion.identity);
            obj.GetComponent<Enemy3>().speed = enemySpeed;
            timer = timeBetweenEnemySpawns;
        }

    }
}
