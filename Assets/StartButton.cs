using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour {
    public GameObject objMenuButton;
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown() {
        TargetBall.instance.StartMove();

        gameObject.SetActive(false);
        objMenuButton.gameObject.SetActive(false);
    }
}
