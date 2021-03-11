using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New artifact", menuName = "Artifact/World3")]
public class World3Artifact : ScriptableObject
{
    public enum Set {Chess, MONOPOLY, Battleship, TicTacToe, Yahtzee, Sorry, Scrabble, LIFE, Operation};
    public enum Rarity {common, rare, epic, mythic, exotic};

    new public string name;
    public Set set;
    public Rarity rarity;
    public Sprite icon = null;
}
