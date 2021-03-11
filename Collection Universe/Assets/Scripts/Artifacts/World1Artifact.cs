using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New artifact", menuName = "Artifact/World1")]
public class World1Artifact : Artifact
{
    new public enum Set {RockBandz, Rainforest, FunPack, Fantasy, Baseball, Dinosaur, Western, ZooAnimals};

    new public Set set;
}
