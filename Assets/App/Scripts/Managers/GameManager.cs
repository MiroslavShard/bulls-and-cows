using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string secret;
    public List<Guess> guesses = new List<Guess>();

    #region Singleton activation
    [HideInInspector] public static GameManager instance;

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

    private void Start()
    {
        CheckGuess("4213");
    }

    public void CheckGuess(string guess)
    {
        guesses.Add(new Guess());
        guesses.Last().guess = guess;

        for (int guessChar = 0; guessChar < 4; guessChar++)
        {
            for (int secretChar = 0; secretChar < 4; secretChar++)
            {
                if (guesses.Last().guess[guessChar] == secret[secretChar])
                {
                    if (guessChar == secretChar) 
                    {
                        guesses.Last().bulls += 1;
                    }
                    else
                    {
                        guesses.Last().cows += 1;
                    }

                    break;
                }
            }
        }
    }
}

[System.Serializable]
public class Guess
{
    public string guess;
    [Space(5)]

    public int bulls = 0;
    public int cows = 0;
}