// Purpose: To detect collisions between the player and collider and update player location and quiz tags

using UnityEngine;
using UnityEngine.UI;

//Must add TMPro if using TMP Text
using TMPro;

public class Trigger : MonoBehaviour
{
    // There are 2 types of text types TMP and Legacy. I have used both in different cases so be careful picking the right one
    [SerializeField] TMP_Text PlayerLocation;

    // This script utilizes Unity's trigger detection (with colliders)
    [SerializeField] Text QuizLocation;

    // Runs when a gameobject first enters the collider everytime it happens
    void OnTriggerEnter(Collider other)
    {
        //This sets the player location text on the left wrist to that of the players location
        PlayerLocation.text = other.gameObject.name;

        //This sets the quizlocation (which location tags it will pull from
        QuizLocation.text = other.gameObject.name;

        //Simple Debug in the console to verify the correct location is being sent to the quizcollection script
        Debug.Log(QuizLocation.text);
    } 
}