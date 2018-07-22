using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objPlayer2 : MonoBehaviour {
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnMouseOver() {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
            gameObject.transform.Translate(new Vector3(Input.touches[0].deltaPosition.x * Time.deltaTime,
                                                       Input.touches[0].deltaPosition.y * Time.deltaTime,
                                                       0));
        }
    }
}
