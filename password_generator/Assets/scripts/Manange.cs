using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manange : MonoBehaviour {
    private GameObject number_gameobj;
    private Object number_obj;

    private GameObject button_gameobj;
    private Object button_obj;

    private GameObject sprite_gameobj;
    private Object sprite_obj;

    private GameObject bcg_gameobj;
    private Object bcg_obj;

    private GameObject show_gameobj;
    private Object show_obj;
    // Use this for initialization
    void Start () {
        number_obj = Resources.Load("prefabs/number");
        button_obj = Resources.Load("prefabs/button_panel");
        sprite_obj = Resources.Load("prefabs/sprite_panel");
        bcg_obj = Resources.Load("prefabs/bcg_panel");
        show_obj = Resources.Load("prefabs/show_panel");
        CreateNumber();
        CreateButton();
        CreateSprite();
        CreateBcg();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void CreateSprite() {
        sprite_gameobj = Instantiate(sprite_obj) as GameObject;
    }
    public  void CreateNumber() {
        number_gameobj = Instantiate(number_obj) as GameObject;
        Destroy(number_gameobj, 5.0f);
    }

    public void CreateButton() {

        button_gameobj = Instantiate(button_obj) as GameObject;
        button_gameobj.GetComponent<Canvas>().worldCamera = Camera.main;
    }

    public void CreateBcg()
    {
        bcg_gameobj = Instantiate(bcg_obj) as GameObject;
        bcg_gameobj.GetComponent<Canvas>().worldCamera = Camera.main;
    }
    public void CreateShow()
    {
        show_gameobj = Instantiate(show_obj) as GameObject;
        show_gameobj.GetComponent<Canvas>().worldCamera = Camera.main;
    }
}
