using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artifact : ScriptableObject
{
    public enum Set {};
    public enum Rarity {common, rare, epic, mythic, exotic};

    new public string name;
    public Set set;
    public Rarity rarity;
    public Sprite icon = null;
}
