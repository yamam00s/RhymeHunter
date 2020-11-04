using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonQuizClass {
    public string top;
    public string bottom;
    public string[] answers;
    public string correct;
}

[System.Serializable]
public class MainController : MonoBehaviour {
    public TextAsset quizCsvJson;
    // private string[] quizItems;

    // Start is called before the first frame update
    void Start() {
        JsonQuizClass inputJsonQuiz = JsonUtility.FromJson<JsonQuizClass>(quizCsvJson.ToString());
        // Debug.Log(jsonQuizClass.bottom);
    }

    // // Update is called once per frame
    // void Update() {
    // }
}
