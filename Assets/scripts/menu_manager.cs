using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu_manager : MonoBehaviour {

    private static menu_manager instance;

    private Canvas main_menu;
    private Canvas options_menu;
    private Canvas game_menu;

    void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this);

        main_menu = this.transform.Find("main_menu").GetComponent<Canvas>();
        options_menu = this.transform.Find("options_menu").GetComponent<Canvas>();
        game_menu = this.transform.Find("game_menu").GetComponent<Canvas>();

        options_menu.enabled = false;
        game_menu.enabled = false;

        Button play = main_menu.transform.Find("play").GetComponent<Button>();
        play.onClick.AddListener(Play);

        Button options = main_menu.transform.Find("options").GetComponent<Button>();
        options.onClick.AddListener(Options);
    }

    void Play() {
        SceneManager.LoadScene("game");
        main_menu.enabled = false;
    }

    void Options() {
        options_menu.enabled = true;
        main_menu.enabled = false;
    }
}
