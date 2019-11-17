using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    private Rigidbody2D rigidbody;
    public float speed;
    private Vector3 gravity;
    public Camera main_camera;

    void Awake() {
        rigidbody = this.GetComponent<Rigidbody2D>();
    }

    void Update() {
        gravity = new Vector3 (Input.acceleration.x, Input.acceleration.y, 0f);
    }

    void FixedUpdate() {
        rigidbody.velocity = gravity * speed * Time.deltaTime;
    }

    void LateUpdate() {
        float y = main_camera.orthographicSize;    
        float x = y * Screen.width / Screen.height;

        rigidbody.position = new Vector3 (Mathf.Clamp(rigidbody.position.x, -x, x), Mathf.Clamp(rigidbody.position.y, -y, y), 0f);
    }
}
