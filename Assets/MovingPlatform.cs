using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private Vector3 position1, position2;
    [SerializeField] [Range(0f,10f)] private float movementDuration;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GoBackAndForth());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator GoBackAndForth(){
        while (true){
            float timeElapsed = 0;
            while (timeElapsed <= movementDuration){
                transform.localPosition = Vector3.Lerp(position1, position2, timeElapsed/movementDuration);
                timeElapsed += Time.deltaTime;
                yield return null;
            }
            timeElapsed = 0;
            while (timeElapsed <= movementDuration){
                transform.localPosition = Vector3.Lerp(position2, position1, timeElapsed/movementDuration);
                timeElapsed += Time.deltaTime;
                yield return null;
            }
        }
    }
}
