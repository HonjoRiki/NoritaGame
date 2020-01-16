using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    public GameObject Target;
    AccessListManager script;

    bool DestroyFrag = false;

    public GameObject Wood;
    public GameObject Leaf;

    Material ml1;     
    Material ml2;
    // Start is called before the first frame update
    void Start()
    {
        script = Target.GetComponent<AccessListManager>();
        
        ml1 = Wood.GetComponent<Renderer>().material;
        ml2 = Leaf.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if(script.AccessFrag)
        {
            DestroyFrag = true;
        }

        if(DestroyFrag)
        {
            ml1.color -= new Color(0, 0, 0, 0.005f);
            ml2.color -= new Color(0, 0, 0, 0.005f);
        }

        if(ml1.color.a <= 0)
        {
            Destroy(gameObject);
        }
    }
}
