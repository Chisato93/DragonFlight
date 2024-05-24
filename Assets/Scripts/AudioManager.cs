using UnityEngine;

public class AudioManager : MonoBehaviour
{
    #region Singletone
    /* ==============================
     *          Sigleton
     * ==============================
     * 
     */
    public static AudioManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }
    #endregion

    AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public AudioClip[] audioSE;

    const int ATTACK = 0, DIE = 1;

    public void AttackSE()
    {
        source.PlayOneShot(audioSE[ATTACK]);
    }

    public void DieSE()
    {
        source.PlayOneShot(audioSE[DIE]);
    }

}
