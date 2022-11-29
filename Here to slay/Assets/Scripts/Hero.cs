using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New card", menuName = "Cards/Hero")]
public class Hero : Card
{
    public enum Class {Bard, Fighter, Guardian, Ranger, Thief, Wizard}
    public Class clase;
    public int cost;
    public bool IsGreater;
    public List<string> actions;

    Hero()
    {
        type = Type.Hero;
    }

}
