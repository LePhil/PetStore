using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskQueueController : MonoBehaviour {

    LinkedList<GameObject> taskList;

	// Use this for initialization
	void Start () {
        taskList = new LinkedList<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void clickedOn(RaycastHit hit)
    {
        taskList.AddLast(hit.collider.gameObject);

        foreach(GameObject go in taskList)
        {
            Debug.Log(go.name);
        }
    }
}
