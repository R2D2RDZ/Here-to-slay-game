using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New card", menuName = "Cards/Leader")]
public class Leader : Card
{
    public enum Class { Bard, Fighter, Guardian, Ranger, Thief, Wizard }
    public Class clase;

    Leader()
    {
        type = Type.Leader;
    }
}
