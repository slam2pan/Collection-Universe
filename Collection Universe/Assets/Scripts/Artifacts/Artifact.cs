using UnityEngine;
using System;

public abstract class Artifact : ScriptableObject, IComparable<Artifact>
{
    public Rarity rarity;
    [SerializeField] public Set set;
    public Sprite icon = null;

    public int CompareTo(Artifact other)
    {
        return this.name.CompareTo(other.name);
    }
}
