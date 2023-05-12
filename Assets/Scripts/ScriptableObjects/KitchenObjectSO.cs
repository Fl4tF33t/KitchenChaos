using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class KitchenObjectSO : ScriptableObject
{
    //Scriptable Object for the kitchen items

    public Transform prefab;
    public Sprite sprite;
    public string objName;
}
