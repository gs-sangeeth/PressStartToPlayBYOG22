using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public GameObject bulletHitEffect;

    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy3>().health--;
            AudioManager.instance.Play("enemyHit");
            Instantiate(bulletHitEffect, transform.position, Quaternion.identity);
            CameraShake.instance.Shake(0.5f,.25f);
            Destroy(gameObject);
        }
    }
}
