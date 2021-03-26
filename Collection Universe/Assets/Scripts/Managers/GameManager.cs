using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton

    public static GameManager instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    #endregion

    [SerializeField] private InputHandler inputHandler;
    public static string currentWorld;
    private float incomeAmount;
    public float IncomeAmount { get {return incomeAmount;} set {incomeAmount = value;} }

    void Start()
    {
        currentWorld = "World1";    
    }

    // Update is called once per frame
    void Update()
    {
        if (inputHandler.GeneratedIncome()) 
        {
            BalanceManager.Balance += incomeAmount;
        }
    }
}
