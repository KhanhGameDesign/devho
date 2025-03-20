using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField] private float speedDown = 5f;    // Tốc độ rơi
    [SerializeField] private float rotateSpeed = 100f; // Tốc độ xoay

    private Rigidbody2D rb;

    void Start()
    {
        // Lấy Rigidbody2D của GameObject
        rb = GetComponent<Rigidbody2D>();

        // Thiết lập vận tốc rơi xuống
        rb.velocity = new Vector2(0, -speedDown);

        // Thiết lập tốc độ xoay bằng Rigidbody2D
        rb.angularVelocity = rotateSpeed;
    }

    // Tự hủy khi thiên thạch ra khỏi màn hình
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
