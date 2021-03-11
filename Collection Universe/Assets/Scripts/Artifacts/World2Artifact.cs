using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New artifact", menuName = "Artifact/World2")]
public class World2Artifact : ScriptableObject
{
    public enum Set {Drink, Side, Entree, Dessert};
    public enum Rarity {common, rare, epic, mythic, exotic};

    new public string name;
    public Set set;
    public Rarity rarity;
    public Sprite icon = null;
}
