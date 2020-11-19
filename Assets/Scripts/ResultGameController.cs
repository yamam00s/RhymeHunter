using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultGameController : MonoBehaviour {
    public Text resultStatusText;
    public Text resultLyricText;

    void Start() {
        if (MainController.getIsGameClear()) {
            resultStatusText.text = "Game Clear";
            resultLyricText.text = MainController.getResultLyric();
        } else {
            resultStatusText.text = "Game Over";
        }
    }

    public void onClickReturnGame() {
        SceneManager.LoadScene("Title");
    }
}