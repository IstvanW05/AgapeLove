using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider whatIHit)
    {
        if(whatIHit.tag == "Trashcan")
        {
            player.trashCleaned++;
            Destroy(this.gameObject);
        }
    }
}
