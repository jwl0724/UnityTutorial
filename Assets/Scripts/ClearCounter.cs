using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;
    public void Interact() {
        Debug.Log("Interact!");
        Transform kitchObjectTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
        kitchObjectTransform.localPosition = Vector3.zero;

        Debug.Log(kitchObjectTransform.GetComponent<KitchenObject>().GetKitchenObjectSO().objectName);
    }
}
