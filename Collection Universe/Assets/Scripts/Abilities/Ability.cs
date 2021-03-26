using System.Collections;
using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    protected Collection collection;
    protected bool abilityUnlocked = false;
    protected int unlockAmount;
    protected int artifactProgression;
    protected int artifactBenchmark;
    protected float cooldownMin;
    protected bool onCooldown = false;

    void Start()
    {
        collection = Collection.instance;
        collection.onArtifactAddedCallback += UpgradeAbility;
    }

    protected abstract void Activate();
    protected abstract void Upgrade();
    protected abstract void BigUpgrade();

    protected IEnumerator CooldownTimer()
    {
        yield return new WaitForSeconds(cooldownMin * 60);
        onCooldown = false;
    }

    public void UseAbility()
    {
        if (abilityUnlocked && !onCooldown)
        {
            Activate();
            onCooldown = true;
            StartCoroutine("CooldownTimer");
        }
    }

    public void UpgradeAbility()
    {
        if (abilityUnlocked)
        {
            // Upgrade every x artifacts
            if (collection.ArtifactsCollected() % artifactProgression == 0)
            {
                Upgrade();
            }

            // Upgrade when we reach x artifacts
            if (collection.ArtifactsCollected() == artifactBenchmark)
            {
                BigUpgrade();
            }
        }
        else // Unlock at a certain artifact amount
        {
            if (collection.ArtifactsCollected() == unlockAmount)
            {
                abilityUnlocked = true;
            }
        }
    }
}
