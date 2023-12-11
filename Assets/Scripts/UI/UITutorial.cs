using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITutorial : MonoBehaviour
{
    [SerializeField] Button _mainMenu;
    [SerializeField] Button _startGame;
    
    // Start is called before the first frame update
    void Start()
    {
        _mainMenu.onClick.AddListener(MainMenu);
        _startGame.onClick.AddListener(StartGame);
    }

    private void MainMenu()
    {
        ScenesManager.LoadMainMenu();
    }

    private void StartGame()
    {
        ScenesManager.LoadNewGame();
    }
}
