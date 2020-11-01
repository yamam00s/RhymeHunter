using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class StartGameController : MonoBehaviour {
    private AudioSource audioSource;

    void Start () {
        audioSource = GetComponent<AudioSource>();
    }

    void OnClickStartGame() {
        audioSource.PlayOneShot(audioSource.clip);
        SceneManager.LoadScene("Main");
    }
}