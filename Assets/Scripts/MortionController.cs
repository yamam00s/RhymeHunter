using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MortionController : MonoBehaviour {

    private int idX;
    private int idY;
	private Animator animator;

    // Start is called before the first frame update
    void Awake() {
        idX = Animator.StringToHash("x");
        idY = Animator.StringToHash("y");
        animator = GetComponent<Animator>();
    }

    public void moveDirection(float x, float y) {
		if (Mathf.FloorToInt(x) != 0 || Mathf.FloorToInt(y) != 0) {
			animator.SetFloat(idX, x);
			animator.SetFloat(idY, y);
		}
    }
}
