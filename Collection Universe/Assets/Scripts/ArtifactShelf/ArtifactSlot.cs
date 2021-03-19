using UnityEngine;
using UnityEngine.UI;

public class ArtifactSlot : MonoBehaviour
{
    Collection collection;

    void Awake()
    {
        collection = Collection.instance;
    }

    Text textComponent;
    public void ManageArtifact(Artifact artifact)
    {
        // show text of artifact
        textComponent = GetComponentInChildren<Text>();
        textComponent.text = artifact.name;
        // display artifact icon if artifact bool is true
        // right now we just change the color of the text 
        if (collection.isArtifactCollected(artifact))
        {
            textComponent.color = Color.red;
        } else 
        {
            textComponent.color = Color.black;
        }
    }
}
