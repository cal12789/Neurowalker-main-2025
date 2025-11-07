using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    // Makes objects public to the Unity Interactor for easy manipulation of fields 

    [SerializeField] GameObject MainMenu;
    [SerializeField] GameObject TeleportMenu;

    // Method to close the main menu and open the teleport menu

    public void teleportMenu()
    {
        MainMenu.SetActive(false);
        TeleportMenu.SetActive(true);
    }

    // Method to return from teleport menu back to the main menu

    public void BacktoMain()
    {
        TeleportMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
}
