using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBall : MonoBehaviour {
    public static TargetBall instance;
    public Rigidbody2D rbTargetBall;
    public Status BallStatus = Status.Stop;
    Vector2 i;

    public enum Status {
        Move,
        Stop
    }

	// Use this for initialization
    void Start () {
        instance = this;
        rbTargetBall = GetComponent<Rigidbody2D>();
        rbTargetBall.drag = 10000;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void FixedUpdate() {
        
    }

    public float RandomVelue(int velue) {
        if (velue <= 4)
            return 0.1f;
        else if (velue >= 5)
            return -0.1f;
        else
            return 0.1f;
    }

    public void StartMove() {
        BallStatus = Status.Move;
        rbTargetBall.drag = 0;

        int intRandomY = Random.Range(0, 9);
        Vector2 vec = new Vector2(Random.Range(-0.1f, 0.1f), RandomVelue(intRandomY));
        rbTargetBall.AddForce(vec);
    }

    public void StopMove() {
        BallStatus = Status.Stop;
        rbTargetBall.drag = 10000;
        gameObject.transform.position = new Vector2(0, 0);
    }
}
