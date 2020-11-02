using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof (MortionController))]
// [RequireComponent(typeof (StartGameController))]
public class HaterController : MonoBehaviour {
    private GameObject player;
    private MortionController Mortion;

    void Start() {
        player = GameObject.Find("Player");
        Mortion = GetComponent<MortionController>();
        Debug.Log(StartGameController.GetDifficulty());
        // 難易度Easyの場合はHaterを表示しない
        if (StartGameController.GetDifficulty() == 0) {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void FixedUpdate() {
        float x = Input.GetAxisRaw("Horizontal");
		float y = Input.GetAxisRaw("Vertical");
        if (x == 0 && y == 0) {
            return;
        }
        Mortion.MoveDirection(x, y);
        Vector2 playerPosition = player.transform.position;
        transform.position = Vector2.MoveTowards(transform.position, playerPosition, 1);
    }

    void OnCollisionEnter2D(Collision2D collisionInfo) {
        SceneManager.LoadScene("Result");
    }
}
