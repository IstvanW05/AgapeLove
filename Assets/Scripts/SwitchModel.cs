using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchModel : MonoBehaviour
{
    private GlobalManager globalManager;
    void Start()
    {
        var Renderer = this.GetComponent<Renderer>();
        globalManager = GameObject.FindWithTag("GameController").GetComponent<GlobalManager>();
        
        switch(globalManager.charID)
        { 
            case 0:
                Renderer.material.SetColor("_Color", Color.red);
                break;
            case 1:
                Renderer.material.SetColor("_Color", Color.blue);
                break;
        }
    }
}