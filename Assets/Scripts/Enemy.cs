using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = .5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distY = moveSpeed * Time.deltaTime;
        transform.position += new Vector3(0, -distY);
    }
}
