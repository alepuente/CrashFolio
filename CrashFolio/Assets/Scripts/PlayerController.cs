using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rgb;
    public float _movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _rgb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (InputManager.instance.GetHAxis()>0)
        {
            _rgb.AddForce(transform.right * _movementSpeed);
        }
        else if(InputManager.instance.GetHAxis() < 0)
        {
            _rgb.AddForce(-transform.right * _movementSpeed);
        }

        if (InputManager.instance.GetVAxis() > 0)
        {
            _rgb.AddForce(transform.forward * _movementSpeed);
        }
        else if(InputManager.instance.GetVAxis() < 0)
        {
            _rgb.AddForce(-transform.forward * _movementSpeed);
        }
    }
}
