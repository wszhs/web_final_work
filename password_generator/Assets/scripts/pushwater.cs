using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pushwater : MonoBehaviour {
    private int count = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (count <= 100)
        {
            count++;
            GetComponent<Image>().fillAmount = count / 100.0f;
        }
	}
}
