using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
   public static int playerCount;
   public static string[] playerName;
   public InputField fieldCountPlayer;
   private InputField[] fieldNamePlayer;
   public GameObject inputfield;
   public GameObject personsPanel;
   public Transform parent;
   public GameObject errorMax;
public GameObject errorMin; 
public GameObject NamePanel;
public GameObject Pravila;
   void Start()
   {
       if (playerCount==0)
       {
           NamePanel.SetActive(true);
           GameManager.instance.currentWave = 0;
           if (GameManager.instance.isFirstTime)
           {
           Pravila.SetActive(true);
           GameManager.instance.isFirstTime = false;
           } else
           {
              Pravila.SetActive(false); 
           }
           Time.timeScale = 0f;
       }
       else {
            Time.timeScale = 1f;
            Pravila.SetActive(false);
            NamePanel.SetActive(false);
       }
   }
   public void SetCount()
   {
       playerCount = Convert.ToInt32(fieldCountPlayer.text);
       if (playerCount>6)
       {
           errorMax.SetActive(true);
       } else if (playerCount<=0)
       {
           errorMin.SetActive(true);
       } else
       {
        fieldNamePlayer = new InputField[playerCount];
        playerName = new string[playerCount];
        GameManager.instance.countWave = 10 - playerCount;
        GameManager.instance.currentPlayer = 0;
        for (int i=0; i<playerCount; i++)
        {
           GameObject nameField = Instantiate(inputfield, transform.position, Quaternion.identity) as GameObject;
           nameField.transform.SetParent(parent);
           nameField.transform.localScale = new Vector2(1f,1f);
           nameField.GetComponentInChildren<Text>().text = "№ "+(i+1).ToString();
           fieldNamePlayer[i] = nameField.GetComponent<InputField>();
        }
        personsPanel.SetActive(false);
       }
   }
   public void SetNames()
   {
       for (int i=0; i<playerCount; i++)
       {
           playerName[i] = fieldNamePlayer[i].text;
       }
       Time.timeScale = 1f;
   }
}
