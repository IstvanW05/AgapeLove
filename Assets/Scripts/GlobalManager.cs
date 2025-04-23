using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    public int hearts;
    public bool gotHeart;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    
    public void addHeart()
    {
        hearts++;
    }

    public void setGotHeart()
    {
        gotHeart = true;
    }

    public void resetGotHeart()
    {
        gotHeart = false;
    }
}
