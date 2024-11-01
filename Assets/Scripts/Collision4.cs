using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision4 : MonoBehaviour
{
    public GameObject _gameObject;
    public Rotator scriptR; 

    void Start() 
    {
        scriptR = _gameObject.GetComponent<Rotator>();
    }

    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other) 
    {     

        if (other.gameObject.CompareTag("Player"))
        {
            scriptR.active = true; 
        }
    }

    public void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            scriptR.active = false;
        }
    }

}
