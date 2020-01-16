using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointController : MonoBehaviour
{
    public GameObject Display;
    public GameObject Player;
    public bool AccessFrag;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(AccessFrag)
        {
            Display.SetActive(true);
        }
        else
        {
            Display.SetActive(false);
        }
    }
}
