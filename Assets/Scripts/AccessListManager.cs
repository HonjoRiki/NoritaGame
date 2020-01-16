using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessListManager : MonoBehaviour
{
    public List<GameObject> PointList;
    public bool AccessFrag = false;

    int Count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject go in PointList)
        {
            PointController script = go.GetComponent<PointController>();
            if(!script.AccessFrag)
            {
                Count = 0;
                break;
            }
            Count++;
        }
        if(Count == PointList.Count)
        {
            AccessFrag = true;
        }
    }
}
