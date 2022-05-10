using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "Card", order = 0)]
public class Scriptableobject : MonoBehaviour
{
    public int Health;
    public int Damage;
    public int ManaCost;
    public string CreatureType;
    public string Name;
    public Sprite Image;
    public string Color;
    public int Physical;
    public int Mental;


}
