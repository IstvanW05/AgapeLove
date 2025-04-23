using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBehavior : MonoBehaviour
{
    public GameObject Dialogue;
    public GameObject Dialogue2;
    public bool HasRead;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider whatIHit) //this function is called when the object it is attached to (in this case, the phone) collides with *any* trigger
    {
        if (whatIHit.tag == "Partner") //this if statement checks if the object the phone collided with is the partner
            Dialogue.SetActive(true); //if the phone is near the partner, the dialogue box pops up

        if(whatIHit .tag == "Player")
        {
            if (HasRead == false)
            {
                HasRead = true;
                Dialogue2.SetActive(true);
            }
        }
    }


}
