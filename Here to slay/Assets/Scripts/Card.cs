using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : ScriptableObject
{
    public enum Type {Challenge, Hero, Item, Leader, Magic, Modifier, Monster};
    public new string name;
    [HideInInspector] public Type type;
    [TextArea] public string description;
    public Sprite image;

   

}

