using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    private Rigidbody2D rigidbody;
    private float rigidbody_dial;
    public float speed;
    private Vector3 gravity;
    public Camera main_camera;

    void Awake() {
        rigidbody = this.GetComponent<Rigidbody2D>();
    }

    void Update() {
        gravity = new Vector3 (Input.acceleration.x, Input.acceleration.y, 0.0f);
    }

    void FixedUpdate() {
        rigidbody.velocity = gravity * speed * Time.deltaTime;
    }

    void LateUpdate() {
        float y = main_camera.orthographicSize;    
        float x = y * Screen.width / Screen.height;

        //rigidbody.position = new Vector3 (Mathf.Clamp(rigidbody.position.x, -x, x), Mathf.Clamp(rigidbody.position.y, -y, y), 0.0f);

        if (rigidbody.position.y < -y + 0.5f) {
            rigidbody.position = new Vector3 (rigidbody.position.x, -y + 0.5f, 0.0f);
        }

        if (rigidbody.position.y > y - 0.5f) {
            rigidbody.position = new Vector3 (rigidbody.position.x, y - 0.5f, 0.0f);
        }

        if (rigidbody.position.x < -x + 0.5f) {
            rigidbody.position = new Vector3 (-x + 0.5f, rigidbody.position.y, 0.0f);
        }

        if (rigidbody.position.x > x - 0.5f) {
            rigidbody.position = new Vector3 (x - 0.5f, rigidbody.position.y, 0.0f);
        }
    }
}
