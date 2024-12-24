using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Teleporter otherEnd;
    private float cooldown = 7;
    public float currentCooldown = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentCooldown > 0){
            currentCooldown -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (currentCooldown > 0){
            return;
        }
        collision.gameObject.transform.position = otherEnd.transform.position;
        otherEnd.currentCooldown = cooldown;
    }
}
