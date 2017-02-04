using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianMovement : MonoBehaviour {

    private float speed;
    private Vector3 target;
    private bool goingRight = true;

	void Start () {
        speed = Random.Range(0.5f, 2.0f);
        target = new Vector3(transform.position.x + 20, transform.position.y, transform.position.z);
	}
	
	void Update () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);

        if( Mathf.Abs(transform.position.x - target.x) < 0.1)
        {
            if(goingRight)
            {
                target = new Vector3(transform.position.x - 20, transform.position.y, transform.position.z);
            } else {
                target = new Vector3(transform.position.x + 20, transform.position.y, transform.position.z);
            }
            goingRight = !goingRight;
        } 
	}
}
