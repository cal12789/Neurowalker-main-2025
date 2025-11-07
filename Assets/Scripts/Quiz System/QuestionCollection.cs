using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class QuestionCollection : MonoBehaviour
{
    private QuizQuestion[] allQuestions;
    private QuizQuestion[] DorsalRootGanglionQuestion;
    public QuizQuestion finalQuestion;
    public QuizQuestion finalDRGQuestion;
    public QuizQuestion finalBrainstemQuestion;
    public QuizQuestion finalThalamusQuestion;
    public QuizQuestion finalPrimarySomatoSensoryCortexQuestion;
    public QuizQuestion errorQuestion;
    [SerializeField] Text PlayerLocation;
    private string nextLocation;
    [SerializeField] GameObject tpDRG;
    [SerializeField] GameObject player;

    private void Awake()
    {
        LoadAllQuestions();
        nextLocation = "DorsalRootGanglion";
    }

    private void LoadAllQuestions()
    {
        allQuestions = Resources.LoadAll<QuizQuestion>("Questions");

    }

    public QuizQuestion GetUnaskedQuestion()
    {
        //here should add collider check as this is the filter for quesitons to be asked
        Debug.Log("Scene Name" + SceneManager.GetActiveScene().name);
        if (SceneManager.GetActiveScene().name == "Scene1")
        {

            if (PlayerLocation.text == "DorsalRootGanglion" && nextLocation == "DorsalRootGanglion")
            {
                Debug.Log("Check 1");
                if (allQuestions
                    .Where(t => t.Quizlocation == "DorsalRootGanglion")
                    .Where(t => t.SceneName == "Scene1")
                    .Any(t => t.Asked == false)
                    )
                {
                    Debug.Log("Check 2");
                    var question = allQuestions
                         .Where(t => t.Asked == false)
                         .Where(t => t.Quizlocation == "DorsalRootGanglion")
                         .Where(t => t.SceneName == "Scene1")
                         .FirstOrDefault();

                    question.Asked = true;

                    return question;
                }

                else
                {
                    Debug.Log("Check 3");
                    var question = finalDRGQuestion;
                    nextLocation = "Brainstem";
                    return question;
                }
            }
            if (PlayerLocation.text == "Brainstem" && nextLocation == "Brainstem")
            {
                if (allQuestions
                   .Where(t => t.Quizlocation == "Brainstem")
                   .Any(t => t.Asked == false)
                   )
                {
                    var question = allQuestions
                         .Where(t => t.Asked == false)
                         .Where(t => t.Quizlocation == "Brainstem")
                         .Where(t => t.SceneName == "Scene1")
                         .FirstOrDefault();

                    question.Asked = true;

                    return question;
                }

                else
                {
                    var question = finalBrainstemQuestion;
                    nextLocation = "Thalamus";
                    return question;
                }

            }
            if (PlayerLocation.text == "Thalamus" && nextLocation == "Thalamus")
            {
                if (allQuestions
                   .Where(t => t.Quizlocation == "Thalamus")
                   .Any(t => t.Asked == false)
                   )
                {
                    var question = allQuestions
                         .Where(t => t.Asked == false)
                         .Where(t => t.Quizlocation == "Thalamus")
                         .Where(t => t.SceneName == "Scene1")
                         .FirstOrDefault();

                    question.Asked = true;

                    return question;
                }

                else
                {
                    var question = finalThalamusQuestion;
                    nextLocation = "PrimarySomatoSensoryCortex";
                    return question;
                }

            }
            if (PlayerLocation.text == "PrimarySomatoSensoryCortex" && nextLocation == "PrimarySomatoSensoryCortex")
            {
                if (allQuestions
                   .Where(t => t.Quizlocation == "PrimarySomatoSensoryCortex")
                   .Any(t => t.Asked == false)
                   )
                {
                    var question = allQuestions
                         .Where(t => t.Asked == false)
                         .Where(t => t.Quizlocation == "PrimarySomatoSensoryCortex")
                         .Where(t => t.SceneName == "Scene1")
                         .FirstOrDefault();

                    question.Asked = true;

                    return question;
                }

                else
                {
                    var question = finalPrimarySomatoSensoryCortexQuestion;
                    nextLocation = "DorsalRootGanglion";
                    // ResetQuestionsIfAllHaveBeenAsked();
                    player.transform.position = tpDRG.transform.position;
                    foreach (var question1 in allQuestions)
                    {
                        question1.Asked = false;
                        Debug.Log("Reset questions");
                    }

                    return question;
                }
            }
            else
            {
                var question = errorQuestion;

                return question;
            }
        }
        if (SceneManager.GetActiveScene().name == "Scene2")
        {

            if (PlayerLocation.text == "DorsalRootGanglion" && nextLocation == "DorsalRootGanglion")
            {
                Debug.Log("Check 4");
                if (allQuestions
                    .Where(t => t.Quizlocation == "DorsalRootGanglion")
                    .Where(t => t.SceneName == "Scene2")
                    .Any(t => t.Asked == false)
                    )
                {
                    Debug.Log("Check 5");
                    var question = allQuestions
                         .Where(t => t.Asked == false)
                         .Where(t => t.Quizlocation == "DorsalRootGanglion")
                         .Where(t => t.SceneName == "Scene2")
                         .FirstOrDefault();

                    question.Asked = true;

                    return question;
                }

                else
                {
                    var question = finalPrimarySomatoSensoryCortexQuestion;
                    nextLocation = "DorsalRootGanglion";
                    // ResetQuestionsIfAllHaveBeenAsked();
                    player.transform.position = tpDRG.transform.position;
                    foreach (var question1 in allQuestions)
                    {
                        question1.Asked = false;
                        Debug.Log("Reset questions");
                    }

                    return question;
                }
            }
            else
            {
                var question = errorQuestion;
                return question;
            }
        }
        else
        {
            var question = errorQuestion;
            return question;
        }
    }
}
   
    /*
        private void ResetQuestionsIfAllHaveBeenAsked()
        {
            if (allQuestions.Any(t => t.Asked == false) == false)
            {
                ResetQuestions();
            }
        }

        private void ResetQuestions()
        {
            foreach (var question in allQuestions)
                question.Asked = false;
        }
    */