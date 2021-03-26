using UnityEngine;
using UnityEngine.UI;

public class BuyBoxText : MonoBehaviour
{
    private Text text;

    void Awake()
    {
        text = GetComponent<Text>();
    }

    public void ChangeBoxText(float boxCost)
    {
        text.text = "Buy box for " + boxCost + "!";
    }
}
