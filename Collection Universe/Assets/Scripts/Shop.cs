using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject shopMenu;
    private BalanceManager balanceManager;
    private int boxCost = 100;

    void Start()
    {
        balanceManager = BalanceManager.instance;
    }

    public void ToggleShopMenu()
    {
        shopMenu.SetActive(!shopMenu.activeSelf);
    }

    public void SelectLootBox()
    {
        balanceManager.PurchaseLootBox(boxCost);   
    }

}
