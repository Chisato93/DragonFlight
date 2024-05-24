using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{
    public float scrollSpeed = .5f;
    private Material material;

    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newOffest = material.mainTextureOffset;
        newOffest.Set(0, newOffest.y + (scrollSpeed * Time.deltaTime));
        material.mainTextureOffset = newOffest;
    }
}
