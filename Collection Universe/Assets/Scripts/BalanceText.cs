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

    public void UpdateBalanceText(float balanceAmount) 
    {
        balanceText.text = "Bitcoin: " + balanceAmount;
    }
}
