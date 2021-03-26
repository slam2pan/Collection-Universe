public class PassiveIncome : Ability
{
    public GameManager gameManager;
    private float incomeBoost = 0.2f;

    void Start()
    {
        gameManager = GameManager.instance;
        abilityUnlocked = true;
        artifactProgression = 10;
        artifactBenchmark = 200;
    }

    // This is a passive ability, so we do not do anything on "Activate"
    protected override void Activate()
    {
        return;
    }

    protected override void Upgrade()
    {
        gameManager.IncomeAmount *= (1 + incomeBoost);
    }

    protected override void BigUpgrade()
    {
        throw new System.NotImplementedException();
    }
}
