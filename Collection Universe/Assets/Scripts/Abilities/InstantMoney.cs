public class InstantMoney : Ability
{
    public GameManager gameManager;
    private float clickAmount = 500;
    private float clickBoost = 0.2f;

    void Start()
    {
        gameManager = GameManager.instance;

        unlockAmount = 20;
        artifactProgression = 10;
        artifactBenchmark = 100;
        cooldownMin = 5;
    }

    protected override void Activate()
    {
        BalanceManager.Balance += gameManager.IncomeAmount * clickAmount;
    }

    protected override void Upgrade()
    {
        clickAmount *= (1 + clickBoost);
    }

    protected override void BigUpgrade()
    {
        throw new System.NotImplementedException();
    }
}
