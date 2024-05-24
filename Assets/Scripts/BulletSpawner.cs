using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bullet;
    public float launch_delay_time = 1f;

    void Start()
    {
        InvokeRepeating("GenerateBullet", launch_delay_time, launch_delay_time);
    }

    private void GenerateBullet()
    {
        Instantiate(bullet, this.transform.position, Quaternion.identity);
    }
}
