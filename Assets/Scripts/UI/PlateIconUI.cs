using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateIconUI : MonoBehaviour
{
    [SerializeField]
    private PlateKitchenObject plateKitchenObject;
    [SerializeField]
    private Transform iconTemplate;

    private void Awake()
    {
        iconTemplate.gameObject.SetActive(false);
    }

    private void Start()
    {
        plateKitchenObject.OnIngredientAdded += PlateKitchenObject_OnIngredientAdded;
    }

    private void PlateKitchenObject_OnIngredientAdded(object sender, PlateKitchenObject.OnIngredientAddedEventArgs e)
    {
        UpdateVisual();
    }

    private void UpdateVisual()
    {
        foreach (Transform child in transform)
        {
            if (child == iconTemplate)
            {
                iconTemplate.gameObject.SetActive(false);
                continue;
            }

            Destroy(child.gameObject);
        }
        foreach (KitchenObjectSO kitchenObjectSO in plateKitchenObject.GetKitchenObjectSOList()) 
        {
            Instantiate(iconTemplate, transform);
            iconTemplate.gameObject.SetActive(true);
            iconTemplate.GetComponent<PlateIconSingleUI>().SetKitchenObjectSO(kitchenObjectSO);
        }  
    }
}
