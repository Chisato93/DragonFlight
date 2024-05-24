using UnityEngine;

public class Explosion : MonoBehaviour
{
    private Animator anim;
    public float DestroyTime { get; set; }

    void Start()
    {
        anim = GetComponentInChildren<Animator>();

        DestroyTime = anim.GetCurrentAnimatorClipInfo(0).Length;

        Invoke("DestroyParticle", DestroyTime);
    }

    private void DestroyParticle()
    {
        gameObject.SetActive(false);
    }
}
