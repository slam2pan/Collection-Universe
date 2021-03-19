using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject shopMenu;

    public void ToggleShopMenu()
    {
        shopMenu.SetActive(!shopMenu.activeSelf);
    }

}
