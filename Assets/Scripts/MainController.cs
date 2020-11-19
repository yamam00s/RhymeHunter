using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class JsonQuizItem {
    public string topLyric;
    public string bottomLyric;
    public string[] answersLyric;
    public string correctLyric;
}

[System.Serializable]
public class JsonQuizClass {
    public JsonQuizItem quiz1;
    public JsonQuizItem quiz2;
}

[System.Serializable]
public class MainController : MonoBehaviour {
    public TextAsset quizCsvJson;
    public Text topLyricText;
    public Text bottomLyricText;
    public GameObject answers;
    public GameObject haters;
    public static string correctLyric;
    public static int clearQuiz;
    public static string resultLyric;
    private JsonQuizClass inputQuizJson;

    // Start is called before the first frame update
    void Start() {
        clearQuiz = 0;
        JsonQuizClass inputQuizJson = JsonUtility.FromJson<JsonQuizClass>(quizCsvJson.ToString());
        setLyricText(inputQuizJson.quiz1);
        resultLyric = topLyricText.text + "\n" + bottomLyricText.text;
        // 難易度Headの場合はhaters出現
        if (StartGameController.getDifficulty() == 2) {
            haters.SetActive(true);
        }
    }

    void Update() {

    }

    private void setLyricText(JsonQuizItem inputQuizJson) {
        topLyricText.text = inputQuizJson.topLyric;
        bottomLyricText.text = inputQuizJson.bottomLyric;
        Text[] answersText = answers.GetComponentsInChildren<Text>();
        int index = 0;
        foreach(Text answer in answersText) {
            answer.text = inputQuizJson.answersLyric[index];
            index++;
        }
        correctLyric = inputQuizJson.correctLyric;
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

    public static void addClearQuiz() {
		clearQuiz++;
	}
    public static bool getIsGameClear() {
		return clearQuiz == 1;
	}
}
