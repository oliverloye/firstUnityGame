using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyIsPressed : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("f"))
        {
            print("Respect ma dude!");
        }

    }
}
