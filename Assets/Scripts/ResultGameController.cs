using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultGameController : MonoBehaviour {
    public Text resultStatusText;
    public Text resultLyricText;

    void Start() {
        resultLyricText.text = MainController.getResultLyric();
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