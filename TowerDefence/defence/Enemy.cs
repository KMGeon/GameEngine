using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int goldRward = 25;
    [SerializeField] int goldPenalty = 25;
    Bank bank;

    private void Start()
    {
        bank = FindObjectOfType<Bank>();
    }

    public void RewardGolad()
    {
        bank.Deposit(goldRward);
    }
    public void StealGold()
    {
        bank.Withdraw(goldPenalty);
    }
}
