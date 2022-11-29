using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New card", menuName = "Cards/Item")]
public class Item : Card
{
    public enum Enchant {Normal, Cursed};

    public Enchant enchant;

    Item()
    {
        type = Type.Item;
    }

}
