using UnityEngine;

public class ArtifactInfoManager : MonoBehaviour
{
    #region Singleton

    public static ArtifactInfoManager instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }
    #endregion

    public ArtifactInfo artifactInfo;

    public void OpenArtifactInfo(string artifactName) 
    {
        artifactInfo.gameObject.SetActive(true);
        artifactInfo.AddArtifactInfo(artifactName);
    }
}
