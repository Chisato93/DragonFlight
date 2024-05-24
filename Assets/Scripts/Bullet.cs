using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        float dirY = moveSpeed * Time.deltaTime;
        Vector3 dir = new Vector2(0, dirY);
        transform.Translate(dir);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);

            Destroy(this.gameObject);
        }
    }
}
