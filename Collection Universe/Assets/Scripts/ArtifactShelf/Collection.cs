using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    private CollectionUI collectionUI;

    private Dictionary<Artifact, int> artifactsCollected;
    private Dictionary<Set, int> setCollected;

    #region Singleton

    public static Collection instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    #endregion

    void Start()
    {
        artifactsCollected = new Dictionary<Artifact, int>();
        setCollected = new Dictionary<Set, int>();
        collectionUI = GameObject.Find("Canvas").GetComponent<CollectionUI>();
    }

    public void Add(Artifact artifact)
    {
        // if the artifact is a duplicate, we assume the set has already been assigned
        if (artifactsCollected.ContainsKey(artifact))
        {
            artifactsCollected[artifact]++;
        } else 
        {
            if (setCollected.ContainsKey(artifact.set))
            {
                setCollected[artifact.set]++;
            } else 
            {
                setCollected.Add(artifact.set, 1);
            }

            artifactsCollected.Add(artifact, 1);
        } 

        collectionUI.UpdateSetUI(artifact.set);
    }

    public bool isArtifactCollected(Artifact artifact)
    {
        return artifactsCollected.ContainsKey(artifact);
    }

    public int setItemsCollected(Set set)
    {
        return setCollected.TryGetValue(set, out int value) ? value : 0;
    }
}
