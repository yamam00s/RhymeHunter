using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonQuizClass {
    public string topLyric;
    public string bottomLyric;
    public string[] answersLyrics;
    public string correctLyric;
}

[System.Serializable]
public class MainController : MonoBehaviour {
    public TextAsset quizCsvJson;
    // public Text topLyricText;
    // public Text bottomLyricText;
    // private string[] quizItems;

    // Start is called before the first frame update
    void Start() {
        JsonQuizClass inputQuizJson = JsonUtility.FromJson<JsonQuizClass>(quizCsvJson.ToString());
        // topLyricText.text = inputQuizJson.topLyric;
        // bottomLyricText.text = inputQuizJson.bottomLyric;
        // Debug.Log(jsonQuizClass.bottom);
    }

    // // Update is called once per frame
    // void Update() {
    // }
}
