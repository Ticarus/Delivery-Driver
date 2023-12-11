using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //add this to be able to use Unity's UI library

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button _startGame;
    [SerializeField] Button _tutorial;
    [SerializeField] Button _exitGame;

    // Start is called before the first frame update
    void Start()
    {
        _startGame.onClick.AddListener(StartGame);  //You have to AddListener so the button could work when you click on it
        _tutorial.onClick.AddListener(Tutorial);
        _exitGame.onClick.AddListener(ExitGame);
    }

    private void StartGame()
    {
        ScenesManager.LoadNewGame();
    }

    private void Tutorial()
    {
        ScenesManager.LoadTutorial();
    }

    private void ExitGame()
    {
        Application.Quit();  //This is used to close the game (it doesn't work in the play mode of the editor, only works in build)
    }
}
