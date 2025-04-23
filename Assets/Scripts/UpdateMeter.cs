using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateMeter : MonoBehaviour
{
    public GlobalManager global;
    public Sprite[] meter;
    public Image currentMeter;
    // Start is called before the first frame update
    void Start()
    {
        int curHearts = global.hearts;
        currentMeter.sprite = meter[curHearts];
    }
}
