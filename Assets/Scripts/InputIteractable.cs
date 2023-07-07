using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputIteractable : MonoBehaviour
{
    public InputField[] field;
    public bool canWrite;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<field.Length; i++)
        {
            field[i].readOnly = !canWrite;
        }
    }
}
