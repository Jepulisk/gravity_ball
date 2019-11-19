using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu_manager : MonoBehaviour {

    private static menu_manager instance;

    public Canvas main_menu;

    public Button play;
    public Button options;

    public Canvas options_menu;

    public Canvas pause_menu;

    public Button resume;

    void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this);

        options_menu.enabled = false;
        pause_menu.enabled = false;

        play.onClick.AddListener(Play);
        options.onClick.AddListener(Options);
        resume.onClick.AddListener(Resume);
    }

    void Update() {
         if(Input.GetKeyDown(KeyCode.Escape)) {
            Pause();
        }
    }

    void Play() {
        SceneManager.LoadSceneAsync("game");
        main_menu.enabled = false;
        game_manager.instance.PlayerManager().EnablePlayer();
    }

    void Options() {
        options_menu.enabled = true;
        main_menu.enabled = false;
    }

    void Pause() {
        Time.timeScale = 0.0f;
        pause_menu.enabled = true;
    }

    void Resume() {
        pause_menu.enabled = false;
        Time.timeScale = 1.0f;
    }

    void MainMenu() {
        SceneManager.LoadSceneAsync("main_menu");
        main_menu.enabled = true;
        pause_menu.enabled = false;
        game_manager.instance.PlayerManager().DisablePlayer();
    }
}
