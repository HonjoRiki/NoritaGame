using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public GameObject ActionText;
    PointController script;

    AudioSource AS;
    public AudioClip se1;

    // Start is called before the first frame update
    void Start()
    {
        AS = GetComponent<AudioSource>();
        ActionText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Point")
        {
            ActionText.SetActive(true);
        }

        if(Input.GetMouseButtonDown(0))
        {
            if(other.gameObject.tag == "Point")
            {
                script = other.gameObject.GetComponent<PointController>();
                script.AccessFrag = true;
                AS.PlayOneShot(se1);
            }
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        ActionText.SetActive(false);
    }
    
}
