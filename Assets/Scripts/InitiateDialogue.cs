using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateDialogue : MonoBehaviour
{
    public GameObject talkText;
    public GameObject DialogueBox;
    private Dialogue script;
    // Start is called before the first frame update
    void Start()
    {
        script = DialogueBox.GetComponent<Dialogue>();
    }

    // Update is called once per frame
    void Update()
    {
        if(talkText.activeInHierarchy && Input.GetKeyDown(KeyCode.Space))
        {
            script.enabled = true;
            DialogueBox.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider whatIHit)
    {
        if(whatIHit.tag == "Player")
            talkText.SetActive(true);
    }

    void OnTriggerExit(Collider whatIHit)
    {
        if(whatIHit.tag == "Player")
            talkText.SetActive(false);
    }
}
