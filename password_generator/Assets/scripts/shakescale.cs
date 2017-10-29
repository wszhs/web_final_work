using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class shakescale : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.DOShakeScale(1.2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
