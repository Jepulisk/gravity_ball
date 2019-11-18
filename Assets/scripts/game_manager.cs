using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_manager : MonoBehaviour {

    public static game_manager instance;

    void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this);

        Application.targetFrameRate = 300;
    }

    public main_menu MainMenu() {
        return GameObject.Find("main_menu").GetComponent<main_menu>();
    }

    public options_menu OptionsMenu() {
        return GameObject.Find("options_menu").GetComponent<options_menu>();
    }

    // public game_menu GameMenu() {
    //     return GameObject.Find("game_menu").GetComponent<game_menu>();
    // }
}
