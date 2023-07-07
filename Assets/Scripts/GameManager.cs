using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int currentPlayer;
    public int[] score;
    public bool isFirstTime;
    public int countWave;
    public int currentWave;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        if (PlayerData.playerCount == 0)
        {
            currentWave = 0;
        }

        isFirstTime = true;
    }

    void Update()
    {
        if (currentPlayer>=PlayerData.playerCount && GameController.isPlaced)
        {
            currentWave++;
            currentPlayer = 0;
        }
    }
}
