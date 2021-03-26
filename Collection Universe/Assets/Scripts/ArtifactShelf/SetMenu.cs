using UnityEngine;
using UnityEngine.UI;

public class SetMenu : MonoBehaviour
{
    public Transform setsParent;
    private Set[] set;
    SetSlot[] slots;

    void Awake()
    {
        slots = setsParent.GetComponentsInChildren<SetSlot>(true);
    }

    void Start()
    {
        ChangeSetsInMenu();
    }

    void ChangeSetsInMenu()
    {
        set = Resources.LoadAll<Set>("Artifacts/" + GameManager.currentWorld + "/Sets");

        // If we have a valid set, change the name of the gameobject and the SetName
        // Otherwise, close the panel
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < set.Length)
            {
                slots[i].gameObject.name = set[i].name;
                slots[i].gameObject.GetComponentInChildren<Image>().sprite = set[i].icon;
                slots[i].gameObject.GetComponentInChildren<Text>().text = set[i].name;
            } else 
            {
                slots[i].gameObject.SetActive(false);
            }
        }
    }
}
