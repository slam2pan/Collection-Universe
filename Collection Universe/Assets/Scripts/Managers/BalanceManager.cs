using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanceManager : MonoBehaviour
{
    [SerializeField] private BalanceText balanceText;
    public static int Balance;
    private int startingBalance = 0;

    #region Singleton

    public static BalanceManager instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    #endregion

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
