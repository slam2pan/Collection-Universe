using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New set", menuName = "Artifact/Set")]
public class Set : ScriptableObject
{
    public List<Artifact> items;
    public Sprite icon = null;
}
