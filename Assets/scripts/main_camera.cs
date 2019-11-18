using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_camera : MonoBehaviour {
    
    private Camera camera;

    void Awake() {
        camera = this.GetComponent<Camera>();

        float target_aspect = 9.0f / 16.0f;
        float window_aspect = (float)Screen.width / (float)Screen.height;
        float scale_heigth = window_aspect / target_aspect;

        if (scale_heigth < 1.0f) {  
            Rect rect = camera.rect;

            rect.width = 1.0f;
            rect.height = scale_heigth;
            rect.x = 0;
            rect.y = (1.0f - scale_heigth) / 2.0f;
        
            camera.rect = rect;
        } else {
            float scale_width = 1.0f / scale_heigth;

            Rect rect = camera.rect;

            rect.width = scale_width;
            rect.height = 1.0f;
            rect.x = (1.0f - scale_width) / 2.0f;
            rect.y = 0;

            camera.rect = rect;
        }
    }
}
