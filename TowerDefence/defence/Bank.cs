using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 150;
    [SerializeField] TMP_Text displayText; 
    public int CurrentBalance { get { return currentBalance; } }
    int currentBalance;
    void Start()
    {
        currentBalance = startingBalance;
        UpdateDisplay();
    }

    public void Deposit(int amount)
    {
        currentBalance += amount;
        UpdateDisplay();
    }
    public void Withdraw(int amount)
    {
        currentBalance -= amount;
        UpdateDisplay();
        if (currentBalance < 0)
        {
            ReloadScene();
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void UpdateDisplay()
    {
        displayText.text = "Gold" + currentBalance;
    }
}
