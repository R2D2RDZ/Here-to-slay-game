using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New card", menuName = "Cards/Monster")]
public class Monster : Card
{
    public enum Class {Any, Bard, Fighter, Guardian, Ranger, Thief, Wizard }
    public List<Class> clase;

    Monster()
    {
        type = Type.Monster;
    }
}
