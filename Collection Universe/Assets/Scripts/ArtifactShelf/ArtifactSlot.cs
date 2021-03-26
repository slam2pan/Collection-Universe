using UnityEngine;
using UnityEngine.UI;

public class ArtifactSlot : MonoBehaviour
{
    Collection collection;
    Text textComponent;
    ArtifactInfoManager artifactInfoManager;
    private Button button;

    void Awake()
    {
        collection = Collection.instance;
        artifactInfoManager = ArtifactInfoManager.instance;
        button = GetComponent<Button>();
        button.onClick.AddListener(() => artifactInfoManager.OpenArtifactInfo(GetComponentInChildren<Text>().text.ToString()));
    }

    public void ManageArtifact(Artifact artifact)
    {
        // show text of artifact
        textComponent = GetComponentInChildren<Text>();
        textComponent.text = artifact.name;
        // display artifact icon if artifact bool is true
        // right now we just change the color of the text 
        if (collection.IsArtifactCollected(artifact))
        {
            textComponent.color = Color.red;
        } else 
        {
            textComponent.color = Color.black;
        }
    }
}
