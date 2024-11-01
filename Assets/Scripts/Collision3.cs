using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision3 : MonoBehaviour
{
    public GameObject _gameObject;
    public Material _newMaterial; 
    public Material startMaterial; 
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _gameObject.GetComponent<Renderer>().material = _newMaterial; 
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            _gameObject.GetComponent<Renderer>().material = startMaterial;
        }
    }
}
