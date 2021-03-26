using UnityEngine;

[CreateAssetMenu(fileName = "New box", menuName = "TreasureBox")]
public class TreasureBox : ScriptableObject
{
    public int commonOdds;
    public int rareOdds;
    public int epicOdds;
    public int mythicOdds;
    public int exoticOdds;

    // Pick a random artifact for the user to receive
    public Artifact generateReward(string world) 
    {
        // Random number to decide which rarity
        int randomNumber = Random.Range(0, 100);
        Artifact[] artifacts;

        if (randomNumber < commonOdds)
        {
            artifacts = Resources.LoadAll<Artifact>("Artifacts/" + world + "/" + Rarity.Common);
        } else if (randomNumber < commonOdds + rareOdds)
        {
            artifacts = Resources.LoadAll<Artifact>("Artifacts/" + world + "/" + Rarity.Rare);
        } else if (randomNumber < commonOdds + rareOdds + epicOdds)
        {
            artifacts = Resources.LoadAll<Artifact>("Artifacts/" + world + "/" + Rarity.Epic);
        } else if (randomNumber < commonOdds + rareOdds + epicOdds + mythicOdds)
        {
            artifacts = Resources.LoadAll<Artifact>("Artifacts/" + world + "/" + Rarity.Mythic);
        } else
        {
            artifacts = Resources.LoadAll<Artifact>("Artifacts/" + world + "/" + Rarity.Exotic);
        }

        // randomly pick an item out of the chosen box
        // this null check should never happen!
        if (artifacts.Length == 0) {
            Debug.Log("No items in an artifact folder!");
            return null;
        }
        return artifacts[(Random.Range(0, artifacts.Length))];
    }
}
