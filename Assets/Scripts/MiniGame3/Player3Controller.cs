using UnityEngine;
using TMPro;

public class Player3Controller : MonoBehaviour
{
    public float gunRotateSpeed = 10f;
    public float gunRotateAngle = 30f;
    public float gunFireInterval = .5f;
    public float bulletSpeed = 10f;
    float timer = 0f;

    public float playerXSpeed = 2f;
    public float playerXDistance = 5f;

    public Transform firePoint;
    public GameObject gun;
    public GameObject bullet;

    public TextMeshProUGUI bulletCountText;

    public int startBulletCount = 15;

    private int bulletCount;

    private void Start()
    {
        bulletCount = startBulletCount;

        AudioManager.instance.Pause("menuTheme");
    }

    void Update()
    {
        // Rotate Gun
        gun.transform.localEulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * gunRotateSpeed, gunRotateAngle * 2) - gunRotateAngle);

        //Player X movement
        transform.position = new Vector3(Mathf.PingPong(Time.time * playerXSpeed, playerXDistance * 2) - playerXDistance, transform.position.y, transform.position.z);

        //Fire Bullets
        timer -= Time.deltaTime;
        if (timer <= 0 && bulletCount > 0)
        {
            var obj = Instantiate(bullet, firePoint.position, firePoint.rotation);
            bulletCount--;
            obj.GetComponent<Bullet>().speed = bulletSpeed;
            timer = gunFireInterval;
        }

        bulletCountText.text = bulletCount.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy3>().Destroy();
            HealthManager.instance.DecrementHealth();
        }
        else if (collision.gameObject.CompareTag("BulletLoot"))
        {
            bulletCount += collision.gameObject.GetComponent<BulletLoot>().bulletCount;
            AudioManager.instance.Play("reload");
            Destroy(collision.gameObject);
        }
    }
}
