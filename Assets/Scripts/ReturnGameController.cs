using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnGameController : MonoBehaviour {
    public Text resultStatusText;
    public Text resultText;

    void Start() {
        if (MainController.getIsGameClear()) {
            resultStatusText.text = "Game Clear";
        } else {
            resultStatusText.text = "Game Over";
        }
    }

    void OnClickReturnGame() {
        SceneManager.LoadScene("Title");
    }
}