using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gotosettings : MonoBehaviour
{
    public GameObject start;
    public startgameint script;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void go(){
        start.GetComponent<startgameint>().screen = 3;
    }
}