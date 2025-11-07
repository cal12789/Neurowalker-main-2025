using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadingMenu : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject SceneLoadingMenu;


    public void loadingSceneMenu()
    {
        mainMenu.SetActive(false);
        SceneLoadingMenu.SetActive(true);
    }

public void BacktoMain()
{
    SceneLoadingMenu.SetActive(false);
    mainMenu.SetActive(true);
}
}
