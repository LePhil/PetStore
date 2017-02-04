using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAnimator : MonoBehaviour {
	void Start () {
        iTween.MoveBy(gameObject, iTween.Hash("x", -300, "easeType", "linear", "loopType", "loop", "time", 15, "delay", 2));
    }
}
