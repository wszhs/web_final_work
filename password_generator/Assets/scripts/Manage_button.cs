using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manage_button : MonoBehaviour {
    public GameObject[] button;
	// Use this for initialization
	void Start () {
        Invoke("ShowButton", 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void ShowButton() {
        foreach (GameObject i in button) {
            i.SetActive(true);
        }
    }
    public void OneClick() {
        Camera.main.GetComponent<Manange>().CreateShow();
        Destroy(gameObject, 2.0f);
    }
}
