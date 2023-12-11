using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class ScenesManager
{
    public enum Scene  //enum is used to store constants in the form of indexes (be careful on the build settings on the sequence of scenes)
    {
        MainMenu,
        Tutorial,
        Level01,
        Level02,
        Level03,
        Level04,
        Level05,
        FinalScene,
        SecretScene
    }

    public static void LoadScene(Scene scene)  //This method is used to load a scene with a parameter using enum
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public static void LoadMainMenu()  //This is for only loading MainMenu
    {
        SceneManager.LoadScene(Scene.MainMenu.ToString());
    }

    public static void LoadNewGame()  //This is only for starting the game
    {
        SceneManager.LoadScene(Scene.Level01.ToString());
    }

    public static void LoadTutorial()  //This one is for tutorial
    {
        SceneManager.LoadScene(Scene.Tutorial.ToString());
    }

    public static void LoadNextScene()  //This method can load scene after scene according to the scene sequence in the build settings
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public static void LoadSecretScene()  //This method can load SecretScene
    {
        SceneManager.LoadScene(Scene.SecretScene.ToString());
    }
}
