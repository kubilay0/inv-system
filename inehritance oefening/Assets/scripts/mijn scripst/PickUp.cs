using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public float raycastLength;
    public GameObject inventorySlots;
    public GameObject Camera1;
    RaycastHit hit;

    void Update()
    {
        if (Input.GetButtonDown("Pick Up") && Physics.Raycast(Camera1.transform.position, Camera1.transform.forward, out hit, raycastLength) && hit.transform.gameObject.tag == "Item")
        {
            inventorySlots.GetComponent<SlotManager>().AddItemToSlot(hit.transform.gameObject.GetComponent<Refrence>().item);
            Destroy(hit.transform.gameObject);
        }
    }
}