using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerPicUpDrop :MonoBehaviour
{
    PlayerPicUpDrop PlayerControlerScript;
    public Rigidbody rb;
    public BoxCollider coll;
    public Transform player, boxContainer, tppCam;
    public float picUpRange;
    public float dropForwardForce, dropUpwardForce;
    public bool equipped;
    public static bool slotFull;

    private void Start()
    {
        if (!equipped)
        {
            boxScript.enabled = false;
            rb.isKinematic = false;
            coll.isTrigger = false;
        }
        if (equipped)
        {
            boxScript.enabled = true;
            rb.isKinematic = true;
            coll.isTrigger = true;
            slotFull = true;
        }
       
    }

    private void Update ()
    {
        Vector3 distanceToPlayer = player.position - transform.position;
        if
        {
            (!equipped && distanceToPlayer magnitude <= pickUpRange && Input.GetKeyDown(KeyCode.E) && !slotFull)PickUp();
        }

        if
            { (equipped && Input.GetKeyDown(KeyCode.Q)) Drop();
        }
    }
    private void PickUp()
    {
        equipped = true;
        slotFull = true;
        transform.SetParent(boxContainer);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
        transform.localScale = Vector3.one;
        rb.isKinematic = true;
        coll.isTrigger = true;
        boxScript.enblaed = true;
    }
    private void Drop()
    {
        equipped = false;
        slotFull = false;
        transform.SetParent(null);
        rb.isKinematic = false;
        coll.isTrigger = false;
        rb.velocity = player.GetComponent<Rigidbody>().velocity;
        rb.AddForce(tppCam.forward * dropForwardForce, ForceMode.Impulse);
        //rb.AddForce(tppCam.up * dropUpwardForce, ForceMode.Impulse);
        float random = Random.Range(-1f, 1f);
        rb.AddTorque(newVector3(random, random, random) * 10);
        boxScript.enblaed = false;
    }

}