﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof (MortionController))]
public class PlayerController : MonoBehaviour {
    private Rigidbody2D rb2D;
    private MortionController Mortion;
    private Vector2 nowPosition;

    // Start is called before the first frame update
    void Start() {
        rb2D = GetComponent<Rigidbody2D>();
        nowPosition = GetComponent<Transform>().position;
        Mortion = GetComponent<MortionController>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        float x = Input.GetAxisRaw("Horizontal");
		float y = Input.GetAxisRaw("Vertical");
        if (x == 0 && y == 0) {
            return;
        }
        Mortion.moveDirection(x, y);
        Vector2 direction;

        if (Input.GetKey(KeyCode.RightArrow)) {
            direction = new Vector2(1f, 0);
            movePlayer(direction);
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
            direction = new Vector2(-1f, 0);
            movePlayer(direction);
		}
		if (Input.GetKey(KeyCode.UpArrow)) {
            direction = new Vector2(0, 1f);
            movePlayer(direction);
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
            direction = new Vector2(0, -1f);
            movePlayer(direction);
		}
    }

    void OnCollisionEnter2D(Collision2D collisionInfo) {
        if (collisionInfo.gameObject.tag != "Answer") {
            return;
        }

        string getAnsweText = collisionInfo.gameObject.GetComponent<Text>().text;
        if (getAnsweText == MainController.getCorrectLyric()) {
            MainController.addClearQuiz();
        } else {
            SceneManager.LoadScene("Result");
        }
    }

    void movePlayer(Vector2 direction) {
        nowPosition = rb2D.transform.position;
        Vector2 force = nowPosition + direction;
        rb2D.transform.position = force;
    }
}
