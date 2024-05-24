using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singletone
    /* ==============================
     *          Sigleton
     * ==============================
     * 
     */
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }
    #endregion

    public int Score { get; private set; } = 0;
    public int Distance { get; private set; } = 0;

    public TMP_Text scoreText;
    public TMP_Text distText;

    void Start()
    {
        InvokeRepeating("UpdatePerSecond", 0f, 1f);
    }

    private void UpdatePerSecond()
    {
        Score++;
        Distance++;

        SetScore();
        SetDistance();
    }

    public void SetScore(int amt = 0)
    {
        Score += amt;
        scoreText.text = Score.ToString();
    }

    private void SetDistance()
    {
        distText.text = $"{Distance} M";
    }

}
