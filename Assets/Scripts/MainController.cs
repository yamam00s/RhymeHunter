using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public GameObject answers1;
    public GameObject answers2;
    public GameObject haters;
    public static string correctLyric;
    public static int clearQuiz;
    public static string resultLyric;
    private JsonQuizClass inputQuizJson;
    private bool isChangedQuiz;

    // Start is called before the first frame update
    void Start() {
        isChangedQuiz = false;
        clearQuiz = 0;
        resultLyric = "";
        inputQuizJson = JsonUtility.FromJson<JsonQuizClass>(quizCsvJson.ToString());
        setLyricText(inputQuizJson.quiz1);
        // 難易度Headの場合はhaters出現
        if (StartGameController.getDifficulty() == 2) {
            haters.SetActive(true);
        }
        setAnswersText(answers1, inputQuizJson.quiz1);
        setAnswersText(answers2, inputQuizJson.quiz2);
    }

    void Update() {
        if (clearQuiz == 1 && !isChangedQuiz) {
            setLyricText(inputQuizJson.quiz2);
            answers1.SetActive(false);
            answers2.SetActive(true);
            isChangedQuiz = true;
        }
        if (clearQuiz == 2) {
            SceneManager.LoadScene("Result");
        }
    }

    public void setAnswersText(GameObject answers, JsonQuizItem inputQuizJson) {
        Text[] answersText = answers.GetComponentsInChildren<Text>();
        int index = 0;
        foreach(Text answer in answersText) {
            answer.text = inputQuizJson.answersLyric[index];
            index++;
        }
    }

    public void setLyricText(JsonQuizItem inputQuizJson) {
        topLyricText.text = inputQuizJson.topLyric;
        bottomLyricText.text = inputQuizJson.bottomLyric;
        correctLyric = inputQuizJson.correctLyric;
        resultLyric += inputQuizJson.topLyric + "\n" + inputQuizJson.bottomLyric + inputQuizJson.correctLyric + "\n";
    }

    public static string getCorrectLyric() {
		return correctLyric;
	}

    public static string getResultLyric() {
		return resultLyric;
	}

    public static void addClearQuiz() {
		clearQuiz++;
	}
    public static bool getIsGameClear() {
		return clearQuiz == 2;
	}
}
