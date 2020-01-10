using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTankMovement : MonoBehaviour
{
    public float moveSpeed = 5;
    public float turnSpeed = 40;

    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        Move();
        Turn();
    }

    void Move() {
        float v = Input.GetAxisRaw("Vertical1");
        Vector3 offset = transform.forward * moveSpeed * Time.deltaTime * v;

        rigidbody.MovePosition(transform.position + offset);
    }

    void Turn() {
        float h = Input.GetAxisRaw("Horizontal1");
        
        Vector3 currentRotation = transform.rotation.eulerAngles;
        currentRotation.y += turnSpeed * Time.deltaTime * h;

        rigidbody.MoveRotation(Quaternion.Euler(currentRotation));
    }
}
