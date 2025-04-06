using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    public int charID;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    
    //ik i could use a bool but this is to make customization easier
    public void SwitchCharAdd()
    {
        //if the player isnt on the last option (options - 1)
        if(charID < 1)
            charID++;
        //if they are on the last option, loop to start
        else if(charID == 1)
            charID = 0;
    }

    public void SwitchCharSubtract()
    {
        //same as above but for going backwards
        if(charID > 1)
            charID--;
        //if they are on the first option, loop to end
        else if(charID == 0)
            charID = 1;

    }
}
