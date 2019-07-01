using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    List<Item> tempList = new List<Item>();

    public float hor;
    public float ver;
    public Item item;

    public float moveSpeed;
    public Vector3 v;
    public Vector3 rotate;
    public float rotateSpeed;
    public ScriptableObject addSO;

    void FixedUpdate()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        transform.Translate(v * Time.deltaTime * moveSpeed);

        v.x = -hor;
        v.z = -ver;
    }

    private void OnCollisionEnter(Collision c)
    {
        if (c.transform.tag == ("Item"))
        {
            OnActiveItem onActiveItem = c.transform.GetComponent<OnActiveItem>();
            onActiveItem.item.name = onActiveItem.name;
            onActiveItem.item.description = onActiveItem.description;
            onActiveItem.item.dragable = onActiveItem.dragable;
            tempList.Add(onActiveItem.item);
            //GameObject.Find("Health potion").GetComponent<OnActiveItem>().Itemmanager(addSO);
            Destroy(c.gameObject);
            print("Inventory Item");
        } else {
            print("Non-Iventory tem");
            Destroy(c.gameObject);
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    OnActiveItem onActiveItem = other.transform.GetComponent<OnActiveItem>();
    //    onActiveItem.item.name = onActiveItem.name;
    //    onActiveItem.item.description = onActiveItem.description;
    //    onActiveItem.item.dragable = onActiveItem.dragable;
    //    tempList.Add(onActiveItem.item);
    //    print("1");
    //}
}
