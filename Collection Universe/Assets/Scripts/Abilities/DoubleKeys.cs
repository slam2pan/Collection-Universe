public class DoubleKeys : Ability
{
    private float duration = 20f;
    private float durationBoost = 2f;

    void Start()
    {
        unlockAmount = 40;
        artifactProgression = 15;
        artifactBenchmark = 150;
        cooldownMin = 5;
    }

    protected override void Activate()
    {
        throw new System.NotImplementedException();
    }

    protected override void Upgrade()
    {
        duration += durationBoost;
    }

    protected override void BigUpgrade()
    {
        throw new System.NotImplementedException();
    }
}
