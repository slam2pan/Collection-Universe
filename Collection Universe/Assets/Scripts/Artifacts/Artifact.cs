using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Artifact : ScriptableObject
{
    new public string name;
    public Rarity rarity;
    [SerializeField] public Set set;
    public Sprite icon = null;
}
