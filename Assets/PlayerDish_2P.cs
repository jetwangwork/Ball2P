using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDish_2P : MonoBehaviour {
    public static PlayerDish_2P instance;

	// Use this for initialization
	void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DishMove() {
        if(Input.touchCount == 1/* && Input.GetTouch(0).phase == TouchPhase.Moved*/) {
            gameObject.transform.Translate(new Vector3(Input.touches[0].deltaPosition.x * Time.deltaTime,
                                                       0,
                                                       0));
        } else if(Input.touchCount == 2) {
            gameObject.transform.Translate(new Vector3(Input.touches[1].deltaPosition.x * Time.deltaTime,
                                                       0,
                                                       0));
        }
    }
}
