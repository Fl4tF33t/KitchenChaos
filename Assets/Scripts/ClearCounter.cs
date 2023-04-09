using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField]
    private KitchenObjectSO kitchenObjectSO;
    [SerializeField]
    private Transform counterTopPoint;
    public void Interact()
    {
        Transform kitcheObjectTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
        kitcheObjectTransform.localPosition = Vector3.zero;
    }
}
