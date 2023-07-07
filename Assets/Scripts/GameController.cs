using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private Text[] playerText;
    public static bool isPlaced;
    [SerializeField] private GameObject textPrefab;
    [SerializeField] private Text buttonText;
    [SerializeField] private Transform parent;
    [SerializeField] private Color currentColor;
    [SerializeField] private Color defaultColor;
    [SerializeField] private GameObject victoryPanel;
    private bool isOpen = false;

    void Start()
    {
        //Размещение игроков в списке
        if (PlayerData.playerCount!=0)
        {
            SetPlayers();
        }
        else 
        {
            isPlaced = false;
        }
    }
    void Update()
    {
        //Изменение цвета
        if (isPlaced)
        {
            for (int i=0; i<PlayerData.playerCount; i++)
            {
            if (i==GameManager.instance.currentPlayer)
                playerText[i].color = currentColor;
            else
                playerText[i].color = defaultColor;
            }
        }
        //Меню победителей
        if ((GameManager.instance.currentWave>GameManager.instance.countWave) && !isOpen)
        {
            victoryPanel.SetActive(true);
            isOpen = true;
            Time.timeScale = 0f;
        }
        if ((GameManager.instance.currentWave == GameManager.instance.countWave) && (GameManager.instance.currentPlayer == (PlayerData.playerCount - 1)))
        {
            buttonText.text = "Завершить игру";
        } else
        {
            if (GameManager.instance.currentPlayer == (PlayerData.playerCount - 1))
            {
                buttonText.text = "Завершить круг";
            } else
            {
                buttonText.text = "Следующий игрок";
            }
        }

    }
    //Функция размещения игроков
    public void SetPlayers()
    {
        playerText = new Text[PlayerData.playerCount];

        if (GameManager.instance.score.Length != PlayerData.playerCount)
        {
            GameManager.instance.score = new int[PlayerData.playerCount];
        }

        for (int i=0; i<PlayerData.playerCount; i++)
        {
            GameObject player = Instantiate(textPrefab, transform.position, Quaternion.identity) as GameObject;
            player.transform.SetParent(parent);
            player.transform.localScale = new Vector2(1f,1f);
            player.GetComponent<Text>().text = PlayerData.playerName[i] + " : " + GameManager.instance.score[i].ToString();
            playerText[i] = player.GetComponent<Text>();
        }

        isPlaced = true;
    }
    //Функция перехода следующего игрока
    public void NextPlayer()
    {
        GameManager.instance.score[GameManager.instance.currentPlayer] += PanelCheck.correctCount*100;
        GameManager.instance.currentPlayer++;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
