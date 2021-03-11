using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public bool GeneratedIncome()
    {
        return Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.X);
    }
}

