using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            //child is your child transform
            Destroy(child.GetComponent("Script"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
