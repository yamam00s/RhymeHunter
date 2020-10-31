using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameController : MonoBehaviour {
    void OnClickStartGame() {
        SceneManager.LoadScene("Main");
    }
}