using UnityEngine;
using UnityEngine.UI;

public class SetSlot : MonoBehaviour
{
    private Button button;
    private CollectionUI collectionUI;

    // Start is called before the first frame update
    void Start()
    {
        collectionUI = GameObject.Find("Canvas").GetComponent<CollectionUI>();
        button = GetComponentInChildren<Button>();
        button.onClick.AddListener(() => collectionUI.LoadArtifacts(this.gameObject.name));
    }

    public void SetClicked()
    {
        collectionUI.OpenArtifactMenu();
    }
}
