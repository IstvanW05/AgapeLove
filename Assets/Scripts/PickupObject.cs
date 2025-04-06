using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    public GameObject talkText;
    public Transform player;
    public bool isHolding;
    public bool isNear;
    public PlayerMovement script;

    void Update()
    {   
        if(isNear && Input.GetKeyDown(KeyCode.Space))
            isHolding = !isHolding;

        if(isHolding)
        {
            script.enabled = true;
            talkText.SetActive(false);
        }
        else if(!isHolding && isNear)
        {
            script.enabled = false;
            talkText.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider whatIHit)
    {
        if(whatIHit.tag == "Player" && !isHolding)
        {
            talkText.SetActive(true);
            isNear = true;
        }
    }

    void OnTriggerExit(Collider whatIHit)
    {
        if(whatIHit.tag == "Player")
        {
            talkText.SetActive(false);
            isNear = false;
        }
    }
}
