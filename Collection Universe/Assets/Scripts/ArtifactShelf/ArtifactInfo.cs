using UnityEngine;

public class ArtifactInfo : MonoBehaviour
{
    public void AddArtifactInfo(string artifactName) 
    {
        Debug.Log("We clicked on " + artifactName);
    }

    public void CloseMenu()
    {
        gameObject.SetActive(false);
    }
}
