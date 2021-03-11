using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private InputHandler inputHandler;

    // Update is called once per frame
    void Update()
    {
        if (inputHandler.GeneratedIncome()) 
        {
            BalanceManager.Balance += 1;
        }
    }
}
