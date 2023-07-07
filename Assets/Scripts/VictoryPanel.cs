using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictoryPanel : MonoBehaviour
{
    public Text[] textWinner;
    // Start is called before the first frame update
    void Start()
    {
        for (int i= 1; i<PlayerData.playerCount; i++)
        {
            for (int j = 0; j<(PlayerData.playerCount - 1); j++)
            {
                if (GameManager.instance.score[j]<GameManager.instance.score[j+1])
                {
                    string c = PlayerData.playerName[j];
                    PlayerData.playerName[j] = PlayerData.playerName[j+1];
                    PlayerData.playerName[j+1] = c;
                    int b = GameManager.instance.score[j];
                    GameManager.instance.score[j] = GameManager.instance.score[j+1];
                    GameManager.instance.score[j+1] = b;
                }
            }
        }
        for (int i=0; i<3; i++)
        {
            if (i<PlayerData.playerCount)
            {
             textWinner[i].text =  PlayerData.playerName[i] + " : " + GameManager.instance.score[i] + " очков";   
            } else
            {
             textWinner[i].text =  "Нет игрока";
            }
        }
    }
}
