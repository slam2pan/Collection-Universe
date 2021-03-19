using UnityEngine;
using UnityEngine.UI;

public class CollectionUI : MonoBehaviour
{
    public Transform setsParent;
    public Transform artifactsParent;
    ArtifactSlot[] slots;
    Collection collection;

    void Awake()
    {
        slots = artifactsParent.GetComponentsInChildren<ArtifactSlot>(true);
        collection = Collection.instance;
    }

    public void UpdateSetUI(Set set)
    {
        Text completionText = setsParent.Find(set.name).Find("SetCompletion").GetComponent<Text>();
        completionText.text = collection.setItemsCollected(set) + "/" + set.items.Count;
    }

    public void LoadArtifacts(string setName)
    {
        Set thisSet = Resources.Load<Set>("Artifacts/" + GameManager.currentWorld + "/Sets/" + setName);
        // We want the items to appear in alphabetical order
        thisSet.items.Sort();
        for (int i = 0; i < thisSet.items.Count; i++)
        {
            slots[i].gameObject.SetActive(true);
            slots[i].ManageArtifact(thisSet.items[i]);   
        }
    }

    public void OpenArtifactMenu()
    {
        setsParent.gameObject.SetActive(false);
        artifactsParent.parent.gameObject.SetActive(true);
    }
}
