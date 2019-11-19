using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_manager : MonoBehaviour {

    private static player_manager instance;

    public GameObject player;

    void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this);

        player.SetActive(false);
    }

    public void EnablePlayer() {
        player.SetActive(true);
    }

    public void DisablePlayer() {
        player.SetActive(false);
    }
}
