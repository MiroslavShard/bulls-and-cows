using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public InputField[] numbers;
    public Button[] buttons;

    #region Singleton activation
    [HideInInspector] public static InputManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }
    #endregion

    public void OnButtonClick(string buttonID)
    {
        switch (buttonID)
        {
            case "1":
                AddNumber(1);
                break;

            case "2":
                AddNumber(2);
                break;

            case "3":
                AddNumber(3);
                break;

            case "4":
                AddNumber(4);
                break;

            case "5":
                AddNumber(5);
                break;

            case "6":
                AddNumber(6);
                break;

            case "7":
                AddNumber(7);
                break;

            case "8":
                AddNumber(8);
                break;

            case "9":
                AddNumber(9);
                break;

            case "0":
                AddNumber(0);
                break;

            default:
                break;
        }
    }

    public void AddNumber(int number)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i].text == "")
            {
                numbers[i].text = number.ToString();
                buttons[number].interactable = false;
                break;
            }
        }
    }

    public void RemoveNumber(int number)
    {

    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
}