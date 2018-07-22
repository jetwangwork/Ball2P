using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI_2P : MonoBehaviour {
    public Text txScore1P;
    public GameObject objTargetBall;
    public GameObject objStartButton;
    public GameObject objMenuButton;
    int intScore = 0;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnCollisionEnter2D(Collision2D c2d) {
        intScore += 1;
        txScore1P.text = "Score: " + intScore;

        objStartButton.SetActive(true);
        objMenuButton.SetActive(true);
        TargetBall.instance.StopMove();
    }

    private void OnMouseOver() {
        PlayerDish_2P.instance.DishMove();
    }
}
