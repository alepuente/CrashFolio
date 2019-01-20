using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : IInput
{
    public float GetHAxis()
    {
        return Input.GetAxis("Horizontal");
    }

    public float GetVAxis()
    {
        return Input.GetAxis("Vertical");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
