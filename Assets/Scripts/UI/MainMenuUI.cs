using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuUI : MonoBehaviour
{

    [SerializeField] private Button playMultiplayerButton;
    [SerializeField] private Button playSingleplayerButton;
    [SerializeField] private Button quitButton;


    private void Awake()
    {
        playMultiplayerButton.onClick.AddListener(() =>
        {
            KitchenGameMultiplayer.playeMultiplayer = true;
            Loader.Load(Loader.Scene.LobbyScene);
        });
        playSingleplayerButton.onClick.AddListener(() =>
        {
            KitchenGameMultiplayer.playeMultiplayer = false;
            Loader.Load(Loader.Scene.LobbyScene);
        });
        quitButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });

        Time.timeScale = 1f;

    }


}