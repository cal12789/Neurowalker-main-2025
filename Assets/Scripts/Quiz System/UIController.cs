using System;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    [SerializeField]
    GameObject imageCanvas;

    [SerializeField]
    RawImage image;

    [SerializeField]
    private Text questionText;
    [SerializeField]
    private Button[] answerButtons;

    [SerializeField]
    private GameObject correctAnswerPopup;
    [SerializeField]
    private GameObject wrongAnswerPopup;

    [SerializeField]
    private Text correcttotalText;

    private double numberCorrect = 0;
    private double numberAnswered = 0;

    public void SetupUIForQuestion(QuizQuestion question)
    {
        correctAnswerPopup.SetActive(false);
        wrongAnswerPopup.SetActive(false);

        questionText.text = question.Question;
        if (question.FigureImage != null )
        {
            imageCanvas.SetActive(true);
            image.texture = question.FigureImage;
        }
        else
        {
            imageCanvas.SetActive(false);
        }
      //  questionFigure.SetActive(true);
        if (numberAnswered == 0)
        {
            correcttotalText.text = " ";
        }
        else
        {
            string percentage = (numberCorrect / numberAnswered * 100).ToString();
            correcttotalText.text = (percentage + "%");
        }

        for (int i = 0; i < question.Answers.Length; i++)
        {
            answerButtons[i].GetComponentInChildren<Text>().text = question.Answers[i];
            answerButtons[i].gameObject.SetActive(true);
        }

        for (int i = question.Answers.Length; i < answerButtons.Length; i++)
        {
            answerButtons[i].gameObject.SetActive(false);
        }
    }

    public void HandleSubmittedAnswer(bool isCorrect)
    {
        numberAnswered++;
        ToggleAnswerButtons(false);
        if (isCorrect)
        {
            ShowCorrectAnswerPopup();
            numberCorrect++;
        }
        else
        {
            ShowWrongAnswerPopup();
        }
       
    }

    private void ToggleAnswerButtons(bool value)
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].gameObject.SetActive(value);
        }
    }

    private void ShowCorrectAnswerPopup()
    {
        correctAnswerPopup.SetActive(true);
    }

    private void ShowWrongAnswerPopup()
    {
        wrongAnswerPopup.SetActive(true);
    }
}