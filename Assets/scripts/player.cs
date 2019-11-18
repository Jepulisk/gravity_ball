using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    private Rigidbody2D rigidbody;
    private float radius;
    public float speed;
    private Vector3 gravity;
    public Camera main_camera;

    void Awake() {
        rigidbody = this.GetComponent<Rigidbody2D>();
        radius = this.GetComponent<Renderer>().bounds.size.x/2;
    }

    void Update() {
        gravity = new Vector3 (Input.acceleration.x, Input.acceleration.y, 0.0f);
    }

    void FixedUpdate() {
        rigidbody.velocity = gravity * speed * Time.deltaTime;

        float y = main_camera.orthographicSize;    
        float x = y * Screen.width / Screen.height;

        rigidbody.position = new Vector3 (Mathf.Clamp(rigidbody.position.x, -x + radius, x - radius), Mathf.Clamp(rigidbody.position.y, -y + radius, y - radius), 0.0f);
    }

    void LateUpdate() {
        speed += 1.0f;
        print(speed);
    }

    void OnTriggerEnter2D(Collider2D other) {
         Destroy(other.gameObject);
    }
}
