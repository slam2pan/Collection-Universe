using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactShelf : MonoBehaviour
{
    public GameObject setMenu;
    public GameObject setsParent;
    public GameObject artifactsMenu;

    public void ToggleArtifactMenu()
    {
        if (setMenu.activeSelf)
        {
            setMenu.SetActive(false);
        } else
        {
            setMenu.SetActive(true);
            OpenSetsMenu();
        }
    }

    public void OpenSetsMenu()
    {
        setsParent.SetActive(true);
        artifactsMenu.SetActive(false);
    }
}
