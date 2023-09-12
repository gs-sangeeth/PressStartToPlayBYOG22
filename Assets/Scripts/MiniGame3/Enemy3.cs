using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    Transform player;
    Rigidbody2D rb;
    SpriteRenderer sr;

    public GameObject DeathParticles;

    public int maxHealth = 1;

    [HideInInspector]
    public int health;

    public float speed = 5f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        health = maxHealth;
        sr = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        //transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime * 0.25f);
        rb.velocity = (player.position - transform.position).normalized * speed * Time.deltaTime * 10f;

        if (health <= 0)
        {
            Destroy();
        }

        Vector3 moveDirection = gameObject.transform.position - player.position;
        if (moveDirection != Vector3.zero)
        {
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    public void Destroy()
    {
        var particles = Instantiate(DeathParticles, transform.position, Quaternion.identity);
        AudioManager.instance.Play("enemyHit");
        particles.GetComponent<ParticleSystem>().startColor = sr.color;
        Instantiate(DeathParticles, transform.position, Quaternion.identity);

        KillCountManager.instance.EnemyKilled();

        Destroy(gameObject);
    }
}
