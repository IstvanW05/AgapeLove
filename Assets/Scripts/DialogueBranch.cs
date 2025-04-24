using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueBranch : MonoBehaviour
{
    public GameObject[] branches;
    public GlobalManager global;
    private Dialogue script1;
    private Dialogue script2;
    // Start is called before the first frame update
    void Start()
    {
        script1 = branches[0].GetComponent<Dialogue>();
        script2 = branches[1].GetComponent<Dialogue>();
    }

    public void DialogueOption1()
    {
        branches[0].SetActive(true);
        script1.enabled = true;
    }

    public void DialogueOption2()
    {
        branches[1].SetActive(true);
        script2.enabled = true;
    }
}
