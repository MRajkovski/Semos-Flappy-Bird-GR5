using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] private float velocity = 1.5f;
    [SerializeField] private float rotationSpeed = 10f;

    private Rigidbody2D birdRb;


    // Start is called before the first frame update
    void Start()
    {
        birdRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    #if UNITY_STANDALONE || UNITY_STANDALONE_WIN || UNITY_EDITOR

        if (Input.GetMouseButtonDown(0))
        {
            birdRb.velocity = Vector2.up * velocity;
        }

    #elif UNITY_ANDROID
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            birdRb.velocity = Vector2.up * velocity;
        }
    #endif

    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,birdRb.velocity.y * rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.GameOver();
    }
}
