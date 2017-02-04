using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneAnimator : MonoBehaviour {

	void Start () {
        iTween.MoveBy(gameObject, iTween.Hash("z", 500, "easeType", "linear", "loopType", "loop", "time", 20));
    }
}
