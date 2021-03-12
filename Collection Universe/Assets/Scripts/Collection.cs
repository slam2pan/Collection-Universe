﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
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

    public List<Artifact> artifacts = new List<Artifact>();

    public void Add (Artifact artifact)
    {
        artifacts.Add(artifact);
    }

}
