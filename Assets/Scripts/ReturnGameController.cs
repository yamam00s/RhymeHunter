using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnGameController : MonoBehaviour {
    void OnClickReturnGame() {
        Debug.Log("aaa");
        SceneManager.LoadScene("Title");
    }
}