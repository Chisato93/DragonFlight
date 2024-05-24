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

    public void DestroyEnemy(GameObject go)
    {
        AudioManager.instance.DieSE();
        int score = go.GetComponent<Enemy>().score;
        GameManager.instance.SetScore(score);
        Destroy(go);

        explosionParticle.SetActive(true);
        go_bullet.SetActive(false);

        // 파괴 애니메이션 끝나고 사라져야 하는데 안되서 일단 2로 하드코딩
        Invoke("SetOffBullet", 2f);
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
