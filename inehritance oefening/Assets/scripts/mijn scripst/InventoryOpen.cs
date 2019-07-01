using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventoryOpen : MonoBehaviour
{

    public bool inventoryOpen;
    public GameObject inventory;

    void Start()
    {
        inventory.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("Open Inventory"))
        {
            if (inventoryOpen == false)
            {
                inventory.SetActive(true);
                inventoryOpen = true;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                inventory.SetActive(false);
                inventoryOpen = false;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }
}