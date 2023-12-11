using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFinalScene : MonoBehaviour
{
    [SerializeField] Button _mainMenu;
    [SerializeField] Button _exitGame;

    // Update is called once per frame
    void Awake()
    {
        _mainMenu.onClick.AddListener(MainMenu);
        _exitGame.onClick.AddListener(ExitGame);
    }

    private void MainMenu()
    {
        ScenesManager.LoadMainMenu();
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
