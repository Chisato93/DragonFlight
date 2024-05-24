using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed;
    public GameObject go_bullet;
    public GameObject explosionParticle;

    void Update()
    {
        if(this.gameObject.activeSelf)
        {
            float dirY = moveSpeed * Time.deltaTime;
            Vector3 dir = new Vector2(0, dirY);
            transform.Translate(dir);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            explosionParticle.SetActive(true);

            go_bullet.SetActive(false);

            Destroy(collision.gameObject);

            // �ı� �ִϸ��̼� ������ ������� �ϴµ� �ȵǼ� �ϴ� 2�� �ϵ��ڵ�
            Invoke("SetOffBullet", 2f);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            SetOffBullet();
        }
    }

    private void SetOffBullet()
    {
        this.gameObject.SetActive(false);
    }
}
