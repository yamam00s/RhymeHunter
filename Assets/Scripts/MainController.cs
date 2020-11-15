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
    public GameObject answers;
    public static string correctLyric;
    public static bool isGameClear;
    public static string resultLyric;

    // Start is called before the first frame update
    void Start() {
        JsonQuizClass inputQuizJson = JsonUtility.FromJson<JsonQuizClass>(quizCsvJson.ToString());
        topLyricText.text = inputQuizJson.topLyric;
        bottomLyricText.text = inputQuizJson.bottomLyric;
        Text[] answersText = answers.GetComponentsInChildren<Text>();
        int index = 0;
        foreach(Text answer in answersText) {
            answer.text = inputQuizJson.answersLyric[index];
            index++;
        }
        correctLyric = inputQuizJson.correctLyric;
        resultLyric = topLyricText.text + "\n" + bottomLyricText.text;
    }

    public static string getCorrectLyric() {
		return correctLyric;
	}

    public static void setResultLyric(string selectedLyric) {
		resultLyric += selectedLyric;
	}
    public static string getResultLyric() {
		return resultLyric;
	}

    public static void setIsGameClear(bool isClear) {
		isGameClear = isClear;
	}
    public static bool getIsGameClear() {
		return isGameClear;
	}
}
