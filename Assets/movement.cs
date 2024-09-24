using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private int a;
    public int b;
    public float speed;
    public void MoveLeft(){
        transform.position += new Vector3(1,0,0);
    }
    public void MoveRight(){
        transform.position += new Vector3(-1,0,0);
    }
    // start is called before the first frame update
    // this variable determines the speed of the square
    // 
    void Start()
    {
        
    }

    // update is called once per frame
    void Update()
    {
        
    }
}
