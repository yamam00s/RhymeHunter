using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameController : MonoBehaviour {
    private AudioSource audioSource;
    public GameObject selectDifficulty;
    public GameObject startButton;

    void Start () {
        audioSource = GetComponent<AudioSource>();
    }

    public　void OnClickStartButton() {
        audioSource.PlayOneShot(audioSource.clip);
        startButton.SetActive(false);
        selectDifficulty.SetActive(true);
    }
    public　void OnClickSelectDifficulty() {
        audioSource.PlayOneShot(audioSource.clip);
        SceneManager.LoadScene("Main");
    }
}