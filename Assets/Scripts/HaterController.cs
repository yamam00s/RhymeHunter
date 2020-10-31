using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof (MortionController))]
public class HaterController : MonoBehaviour {
    private GameObject playerRb2d;
    private MortionController Mortion;
    void Start() {
        playerRb2d = GameObject.Find("Player");;
        Mortion = GetComponent<MortionController>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        float x = Input.GetAxisRaw("Horizontal");
		float y = Input.GetAxisRaw("Vertical");
        if (x == 0 && y == 0) {
            return;
        }
        Mortion.MoveDirection(x, y);
        Vector2 playerPosition = playerRb2d.transform.position;
        transform.position = Vector2.MoveTowards(transform.position, playerPosition, 1);
    }

    void OnCollisionEnter2D(Collision2D collisionInfo) {
        SceneManager.LoadScene("Result");
    }
}
