using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 1f;
    public int score = 5;

    void Update()
    {
        float distY = moveSpeed * Time.deltaTime;
        transform.position += new Vector3(0, -distY);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }

        else if(collision.CompareTag("Projectile"))
        {
            collision.GetComponent<Bullet>().DestroyEnemy(this.gameObject);
        }

        else if (collision.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }
}
