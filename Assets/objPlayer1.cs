using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objPlayer1 : MonoBehaviour {
    private Rigidbody2D rb;

    // Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
        //    gameObject.transform.Translate(new Vector3(Input.touches[0].deltaPosition.x * Time.deltaTime,
        //                                               Input.touches[0].deltaPosition.y * Time.deltaTime,
        //                                               0));
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //    gameObject.transform.position += new Vector3(0.1f, 0, 0);
        //if (Input.GetKey(KeyCode.LeftArrow))
        //    gameObject.transform.position += new Vector3(-0.1f, 0, 0);
        //if (Input.GetKey(KeyCode.UpArrow))
        //    gameObject.transform.position += new Vector3(0, 0.1f, 0);
        //if (Input.GetKey(KeyCode.DownArrow))
        //gameObject.transform.position += new Vector3(0, -0.1f, 0);

        Vector2 vec = new Vector2(0, 0.1f);
        if (Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(vec);
	}

    private void OnMouseOver() {
        
    }
}
