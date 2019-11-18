using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu_manager : MonoBehaviour {

    void Start() {
        Button play = transform.Find("play").GetComponent<Button>();
        play.onClick.AddListener(Play);

        Button options = transform.Find("options").GetComponent<Button>();
        play.onClick.AddListener(Options);
    }

    void Play() {
        SceneManager.LoadScene("game");
    }

    void Options() {
        
    }
}
