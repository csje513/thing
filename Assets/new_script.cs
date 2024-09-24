using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Camille is the best");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,0,1);
    }
}