using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanceManager : MonoBehaviour
{
    public static BalanceManager instance;

    [SerializeField] private BalanceText balanceText;
    public static int Balance;
    private int startingBalance = 0;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    void Start()
    {
        Balance = startingBalance;
    }

    void Update()
    {
        balanceText.UpdateBalanceText(Balance);
    }

    public void PurchaseLootBox(int amount)
    {
        if (Balance > amount)
        {
            Balance -= amount;
            Debug.Log("We bought a box!");
        } else 
        {
            Debug.Log("Too poor to buy box");
        }
    }

}
