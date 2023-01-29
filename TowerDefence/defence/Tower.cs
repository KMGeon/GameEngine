using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] int cost = 75;
    public bool Createtower(Vector3 position)
    {
        Bank bank = FindObjectOfType<Bank>();
        if (bank.CurrentBalance >= cost)
        {
            Instantiate(gameObject, position, Quaternion.identity);
            bank.Withdraw(cost);
            return true;
        }
        return false;
    }

}
