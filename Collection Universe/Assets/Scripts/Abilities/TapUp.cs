public class TapUp : Ability
{
    private float duration = 30f;

    void Start()
    {
        unlockAmount = 60;
        artifactProgression = 20;
        artifactBenchmark = 200;
        cooldownMin = 10;
    }

    protected override void Activate()
    {
        throw new System.NotImplementedException();
    }

    protected override void Upgrade()
    {
        throw new System.NotImplementedException();
    }

    protected override void BigUpgrade()
    {
        throw new System.NotImplementedException();
    }
}
