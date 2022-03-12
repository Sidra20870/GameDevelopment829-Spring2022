using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPlayer : MonoBehaviour
{

    private Rigidbody2D rigidBody;
    private Vector2 direction;
    public float speed = 10.0f;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.S))
            direction = Vector2.down;
        else if (Input.GetKey(KeyCode.W))
            direction = Vector2.up;
        else
            direction = Vector2.zero;
        
    }

    void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0)
            rigidBody.AddForce(direction * this.speed);
    }

}
