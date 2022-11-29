using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New card", menuName = "Cards/Modifier")]
public class Modifier : Card
{
    public int add;
    public int remove;

    Modifier()
    {
        type = Type.Modifier;
    }
}
