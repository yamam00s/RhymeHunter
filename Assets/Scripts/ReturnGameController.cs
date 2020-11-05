using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnGameController : MonoBehaviour {
    public Text resultStatusText;

    void Start() {
        if (MainController.isGameClear) {
            resultStatusText.text = "Game Clear";
        } else {
            resultStatusText.text = "Game Over";
        }
    }

    void OnClickReturnGame() {
        SceneManager.LoadScene("Title");
    }
}