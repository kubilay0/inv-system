using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    List<Item> tempList = new List<Item>();

    public float hor;
    public float ver;

    public float moveSpeed;
    public Vector3 v;
    public Vector3 rotate;
    public float rotateSpeed;

    void FixedUpdate()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        transform.Translate(v * Time.deltaTime * moveSpeed);

        v.x = -hor;
        v.z = -ver;
    }

    private void OnCollisionEnter(Collision collision) {
        tempList.Add(collision.transform.GetComponent<OnActiveItem>().item);
    }


}
