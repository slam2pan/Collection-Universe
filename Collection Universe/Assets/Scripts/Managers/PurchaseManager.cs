using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseManager : MonoBehaviour
{
    #region Singleton

    public static PurchaseManager instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    #endregion

    private BalanceManager balanceManager;
    public TreasureBox treasureBox;
    public BuyBoxText buyBoxText;
    Collection collection;

    private float boxCost = 1.0f;
    private float costMultiplier = 0.1f;

    void Start()
    {
        balanceManager = BalanceManager.instance;
        collection = Collection.instance;
    }

    public void BuyLootBox()
    {
        if (balanceManager.PurchaseLootBox(boxCost))
        {   
            // create a randomly generated artifact
            Artifact currArtifact = treasureBox.generateReward(GameManager.currentWorld);

            // if the artifact hasn't been collected, increase box cost
            if (!collection.IsArtifactCollected(currArtifact))
            {
                boxCost += boxCost * costMultiplier;
                buyBoxText.ChangeBoxText(boxCost);
            }
            // add the artifact
            collection.Add(currArtifact);
            Debug.Log("Adding " + currArtifact.name);
        }
    }

}
