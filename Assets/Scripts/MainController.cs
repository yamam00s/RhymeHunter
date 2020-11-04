using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JsonQuizClass {
    public string topLyric;
    public string bottomLyric;
    public string[] answersLyric;
    public string correctLyric;
}

[System.Serializable]
public class MainController : MonoBehaviour {
    public TextAsset quizCsvJson;
    public Text topLyricText;
    public Text bottomLyricText;
    public Text Answer1;
    public Text Answer2;
    public Text Answer3;
    public Text Answer4;

    // Start is called before the first frame update
    void Start() {
        JsonQuizClass inputQuizJson = JsonUtility.FromJson<JsonQuizClass>(quizCsvJson.ToString());
        topLyricText.text = inputQuizJson.topLyric;
        bottomLyricText.text = inputQuizJson.bottomLyric;
        Answer1.text = inputQuizJson.answersLyric[0];
        Answer2.text = inputQuizJson.answersLyric[1];
        Answer3.text = inputQuizJson.answersLyric[2];
        Answer4.text = inputQuizJson.answersLyric[3];
    }

    // // Update is called once per frame
    // void Update() {
    // }
}
