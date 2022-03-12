
## Lab1-HelloWorldPong2DFile
### By Muhammad Saqlain
### By Sidra Usman

{
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
}
