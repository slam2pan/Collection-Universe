using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalanceText : MonoBehaviour
{
    private Text balanceText;
    
    // Start is called before the first frame update
    void Start()
    {
        balanceText = GetComponent<Text>();
    }

    public void UpdateBalanceText(int balanceAmount) 
    {
        balanceText.text = "Balance: " + balanceAmount;
    }
}
