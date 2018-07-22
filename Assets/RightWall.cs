using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightWall : MonoBehaviour {
    float time = 0;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        
    }

    private void OnCollisionEnter2D(Collision2D c2d) {
        if (c2d.gameObject.tag == "TargetBall")
            time = 0;
    }

    private void OnCollisionStay2D(Collision2D c2d) {
        if (c2d.gameObject.tag == "TargetBall") {
            time += Time.deltaTime;

            if (time > 0.3f) {
                TargetBall.instance.rbTargetBall.AddForce(new Vector2(-0.1f, 0));
                time = 0;
            }
        }
    }
}
