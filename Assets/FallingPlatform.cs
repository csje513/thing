using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    [SerializeField] private float safeTime;
    [SerializeField] private float fallTime;
    private Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator Fall(){
        float timeElapsed = 0;
        Debug.Log(safeTime);
        Debug.Log(timeElapsed);
        while(timeElapsed<safeTime){
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
    }
    private void OnCollisionEnter2D(Collision2D collision){
        // when touched --> start falling
        // should take a certain time to fall
        // fallTime, safeTime
        if (collision.gameObject.CompareTag("Player")){
            StartCoroutine("Fall");
        }
    }


}
