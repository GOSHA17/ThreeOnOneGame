using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratorWord : MonoBehaviour
{
    public string[] titles;
    private string letter = "абвгдежзиклмнопрстуфхцчшщюя";
    public Text txtLetter,txtTitle1,txtTitle2,txtTitle3;
    public InputField field1, field2, field3;
    public GameObject error2;
    public GameObject victoryMenu;
    private string answer1,answer2,answer3;
    int RandomNumberOfLetter, RandomNumberOfTitle1,RandomNumberOfTitle2,RandomNumberOfTitle3;

    // Start is called before the first frame update
    void Start()
    {
        //Генерация и вывод названий и буквы
        RandomNumberOfLetter = Random.Range(0,27);
        RandomNumberOfTitle1 = Random.Range(0,titles.Length);
        RandomNumberOfTitle2 = Random.Range(0,titles.Length);
        RandomNumberOfTitle3 = Random.Range(0,titles.Length);
        txtLetter.text = "Буква " + letter[RandomNumberOfLetter].ToString();
        txtTitle1.text = titles[RandomNumberOfTitle1].ToString();
        txtTitle2.text = titles[RandomNumberOfTitle2].ToString();
        txtTitle3.text = titles[RandomNumberOfTitle3].ToString();
    }
    //Функция проверки
    public void Check()
    {
        answer1 = field1.text;
        answer2 = field2.text;
        answer3 = field3.text;
        if ((answer1[0].ToString().ToLower() != letter[RandomNumberOfLetter].ToString().ToLower()) || (answer2[0].ToString().ToLower() != letter[RandomNumberOfLetter].ToString().ToLower()) || (answer3[0].ToString().ToLower() != letter[RandomNumberOfLetter].ToString().ToLower()))
        {
            error2.SetActive(true);
        } else
        {
            victoryMenu.SetActive(true);
        }
        
    }
}
