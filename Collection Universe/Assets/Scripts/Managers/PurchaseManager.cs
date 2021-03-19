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
    private int boxCost = 100;
    Collection collection;

    void Start()
    {
        balanceManager = BalanceManager.instance;
        collection = Collection.instance;
    }

    public void BuyLootBox()
    {
        if (balanceManager.PurchaseLootBox(boxCost))
        {
            Artifact currArtifact = treasureBox.generateReward(GameManager.currentWorld);
            //Artifact currArtifact = Resources.Load<Artifact>("Artifacts/World1/Mythic/Baseball");
            collection.Add(currArtifact);
            Debug.Log("Adding " + currArtifact.name);
        }
    }

}
