using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int playerPoints = 100; // 초기 포인트
    public Text pointText;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        UpdateUI();
    }

    public void AddPoints(int amount)
    {
        playerPoints += amount;
        UpdateUI();
    }

    public void SpendPoints(int amount)
    {
        if (playerPoints >= amount)
        {
            playerPoints -= amount;
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        if (pointText != null)
            pointText.text = "Points: " + playerPoints;
    }
}
