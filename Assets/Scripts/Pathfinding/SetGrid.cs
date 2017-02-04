using UnityEngine;
using System.Collections;

namespace PetStore
{
    public class SetGrid : MonoBehaviour {

        public int X = 1;
        public int Y = 1;

        void Start()
        {
            gameObject.GetComponent<Renderer>().material.mainTextureScale = new Vector2(X , Y);
        }
    }
}