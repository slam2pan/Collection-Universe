using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactShelf : MonoBehaviour
{
    public GameObject setMenu;
    public GameObject setsParent;
    public GameObject artifactsMenu;

    public void CloseSetMenu()
    {
        setMenu.SetActive(false);
    }

    public void CloseArtifactMenu()
    {
        artifactsMenu.SetActive(false);
        setMenu.SetActive(false);
    }

    public void OpenSetsMenu()
    {
        setMenu.SetActive(true);
        setsParent.SetActive(true);
        artifactsMenu.SetActive(false);
    }
}
