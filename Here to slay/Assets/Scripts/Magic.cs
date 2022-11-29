using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New card", menuName = "Cards/Magic")]
public class Magic : Card
{
    public List<string[]>  actions;

    Magic()
    {
        type = Type.Magic;
    }
}
