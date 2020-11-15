using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultGameController : MonoBehaviour {
    public Text resultStatusText;

    void Start() {
        if (MainController.getIsGameClear()) {
            resultStatusText.text = "Game Clear";
        } else {
            resultStatusText.text = "Game Over";
        }
    }

    public void onClickReturnGame() {
        SceneManager.LoadScene("Title");
    }
}