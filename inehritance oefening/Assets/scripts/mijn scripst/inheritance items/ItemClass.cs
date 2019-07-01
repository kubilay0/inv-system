using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item", order = 1)]

public class ItemClass : ScriptableObject {
    public Sprite image;
    public string name;
    public string desc;
    public GameObject GO;

   
}
