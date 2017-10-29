using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class rotate : MonoBehaviour {
    public bool right = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (right == true)
        {
            transform.Rotate(new Vector3(0, 0, 1.0f));
        }
        else {
            transform.Rotate(new Vector3(0, 0, -1.0f));
        }
	}
}
