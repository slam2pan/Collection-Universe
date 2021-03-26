public class AutoZX : Ability
{
    private int clicksPerSecond;
    private int clicksPerSecondBoost = 1;
    private float duration = 30;

    void Start()
    {
        unlockAmount = 80;
        artifactProgression = 25;
        artifactBenchmark = 300;
        cooldownMin = 15;
    }

    protected override void Activate()
    {
        throw new System.NotImplementedException();
    }

    protected override void Upgrade()
    {
        clicksPerSecond += clicksPerSecondBoost;
    }

    protected override void BigUpgrade()
    {
        throw new System.NotImplementedException();
    }
}
