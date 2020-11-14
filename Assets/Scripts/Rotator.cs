using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    void Update() {
        // 難易度Headの場合は回転させる
        if (StartGameController.GetDifficulty() == 2) {
            transform.Rotate(new Vector3(0, 0, 500) * Time.deltaTime);
        }
    }
}
