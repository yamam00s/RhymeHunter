using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameController : MonoBehaviour {
    private AudioSource audioSource;
    public GameObject selectDifficulty;
    public GameObject startButton;
    public static int difficulty;

    void Start () {
        audioSource = GetComponent<AudioSource>();
    }

    public void onClickStartButton() {
        audioSource.PlayOneShot(audioSource.clip);
        startButton.SetActive(false);
        selectDifficulty.SetActive(true);
    }

    // 0: Easy, 1: Normal, 2: Hard
    public void onClickSelectDifficulty(int selectedDifficulty) {
        audioSource.PlayOneShot(audioSource.clip);
        difficulty = selectedDifficulty;
        SceneManager.LoadScene("Main");
    }

    public static int getDifficulty(){
		return difficulty;
	}
}