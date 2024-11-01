using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public bool active; 
    // Start is called before the first frame update
    void Start()
    {
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            transform.Rotate(new Vector3(0, 0, 30) * Time.deltaTime * 1.5f);
        }
    }


}
