using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = .5f;

    void Update()
    {
        float distY = moveSpeed * Time.deltaTime;
        transform.position += new Vector3(0, -distY);
    }
}
