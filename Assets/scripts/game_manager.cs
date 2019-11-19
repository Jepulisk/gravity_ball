using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_manager : MonoBehaviour {

    public static game_manager instance;

    public GameObject camera_manager;
    public GameObject menu_manager;
    public GameObject player_manager;

    void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(this);
        }

        DontDestroyOnLoad(this);

        Application.targetFrameRate = 300;
    }

    public camera_manager CameraManager() {
        return camera_manager.GetComponent<camera_manager>();
    }

    public menu_manager MenuManager() {
        return menu_manager.GetComponent<menu_manager>();
    }

    public player_manager PlayerManager() {
        return player_manager.GetComponent<player_manager>();
    }
}
