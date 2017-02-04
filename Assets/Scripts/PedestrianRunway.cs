using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianRunway : MonoBehaviour {

    public GameObject pedestrianPrefab;

    private ArrayList pedestrians;

    void Start () {
        int nrOfPedestrians = Random.Range(2, 6);

        pedestrians = new ArrayList();
        pedestrians.Add(Instantiate(pedestrianPrefab, new Vector3(-10, 0.78f, -6.8f), Quaternion.identity));
	}
	
	void Update () {
	}
}
