// Purpose: Use a button press to open or close the menu. It works by switching the previous condition

using UnityEngine;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] GameObject canvasObj;
    [SerializeField] GameObject quizCanvas;
    [SerializeField] TMP_Text text;
    public Transform target;

    // Same as close menu button script method

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.Start))
        {
            // Switching with previous condition occurs here
            canvasObj.SetActive(!canvasObj.activeSelf);

        }
    }
    public void startQuiz()
    {
        quizCanvas.SetActive(true);
        canvasObj.SetActive(false);
    }
}