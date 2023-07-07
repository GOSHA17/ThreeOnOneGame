using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    //Функция запуска игры
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        for (int i=0; i<PlayerData.playerCount; i++)
        {
            GameManager.instance.score[i] = 0;
        }
        PlayerData.playerCount = 0;
    }
    //Функция рестарта
    public void Restart()
    {
        for (int i=0; i<PlayerData.playerCount; i++)
        {
            GameManager.instance.score[i] = 0;
        }
        PlayerData.playerCount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    //Функция возврата в главное меню
    public void ToMain()
    {
        SceneManager.LoadScene(0);
    }
    //Функция выхода
    public void Exit()
    {
        Application.Quit();
    }
}
